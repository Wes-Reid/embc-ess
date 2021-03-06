using Gov.Jag.Embc.Public.Authentication;
using Gov.Jag.Embc.Public.DataInterfaces;
using Gov.Jag.Embc.Public.Utils;
using Gov.Jag.Embc.Public.ViewModels;
using Gov.Jag.Embc.Public.ViewModels.Search;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gov.Jag.Embc.Public.Controllers
{
    [Route("api/volunteer-task")]
    [Authorize]
    public class VolunteerTasksController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILogger logger;
        private readonly IHostingEnvironment env;
        private readonly IDataInterface dataInterface;
        private readonly ICurrentUser userService;

        public VolunteerTasksController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor,
            ILoggerFactory loggerFactory, IHostingEnvironment env, IDataInterface dataInterface, ICurrentUser user)
        {
            this.dataInterface = dataInterface;
            this.configuration = configuration;
            this.userService = user;

            this.httpContextAccessor = httpContextAccessor;
            logger = loggerFactory.CreateLogger(typeof(VolunteerTasksController));
            this.env = env;
        }


        [HttpPost("task/{id}")]
        public async Task<IActionResult> SetVolunteerTask(string id)
        {
            // get incident task
            var task = await dataInterface.GetIncidentTaskByTaskNumbetAsync(id);
            if (task == null) return NotFound(Json(id));

            // get volunteerTask by incident task id
            var volunteerTask = await dataInterface.GetVolunteerTaskByIncideTaskIdAsync(Guid.Parse(task.Id));

            //if volunteerTask does not exist, create it
            //var volunteerId = HttpContext.User.FindFirstValue(EssClaimTypes.USER_ID);
            var user = this.userService.CurrentUser;
            var volunteerId = user.contactid;
            if (volunteerTask == null)
            {
                var newVolunteerTask = new VolunteerTask()
                {
                    IncidentTaskId = Guid.Parse(task.Id),
                    VolunteerId = int.Parse(volunteerId),
                    LastDateVolunteerConfirmedTask = DateTime.Now,
                    IsValid = true
                };
                volunteerTask = await dataInterface.CreateVolunteerTaskAsync(newVolunteerTask);
            }
            // otherwise update the task
            else
            {
                volunteerTask.LastDateVolunteerConfirmedTask = DateTime.Now;
                volunteerTask.IsValid = true;
                volunteerTask.VolunteerId = int.Parse(volunteerId);
                await dataInterface.UpdateVolunteerTasksAsync(volunteerTask);
            }

            return Json(volunteerTask);
        }


        [HttpGet("active-task")]
        public async Task<IActionResult> GetActiveTask()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var volunteerId = int.Parse(userService.CurrentUser.contactid);
            // get volunteerTask by volunteer id
            var volunteerTask = await dataInterface.GetVolunteerTaskByVolunteerIdAsync(volunteerId);

            var sessionTimeout = configuration.ServerTimeoutInMinutes();

            //check if volunteer task is valid
            var endOfLife = volunteerTask.LastDateVolunteerConfirmedTask.AddMinutes(sessionTimeout);
            if(DateTime.Now > endOfLife || !volunteerTask.IsValid){
                return Json(null);
            }
            return Json(volunteerTask);
        }

        [HttpPut("invalidate-active-task")]
        public async Task<IActionResult> Update()
        {
            var volunteerId = HttpContext.User.FindFirstValue(EssClaimTypes.USER_ID);
            // get volunteerTask by volunteer id
            var volunteerTask = await dataInterface.GetVolunteerTaskByVolunteerIdAsync(int.Parse(volunteerId));

            if(volunteerTask != null){
                volunteerTask.IsValid = false;
                volunteerTask.VolunteerId = int.Parse(volunteerId);
                await dataInterface.UpdateVolunteerTasksAsync(volunteerTask);
            }

            return Ok();
        }
    }
}
