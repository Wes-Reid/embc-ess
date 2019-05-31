using Gov.Jag.Embc.Public.DataInterfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Gov.Jag.Embc.Public.Services.Registrations
{
    public class RegistrationQueryService :
        IRequestHandler<RegistrationQueryRequest, RegistrationQueryResponse>,
        IRequestHandler<RegistrationSummaryQueryRequest, ViewModels.RegistrationSummary>
    {
        private readonly IDataInterface dataInterface;
        private readonly IMediator mediator;

        public RegistrationQueryService(IDataInterface dataInterface, IMediator mediator)
        {
            this.dataInterface = dataInterface;
            this.mediator = mediator;
        }

        public async Task<RegistrationQueryResponse> Handle(RegistrationQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await dataInterface.GetEvacueeRegistrationAsync(request.EssFileNumber);
            RegistrationQueryResponse response;
            if (result != null && result.IsFinalized && string.IsNullOrWhiteSpace(request.Reason))
                response = RegistrationQueryResponse.Error($"Must specify a valid reason to view the complete registration {request.EssFileNumber}");
            else if (result == null)
                response = RegistrationQueryResponse.NotFound(request.EssFileNumber);
            else
            {
                response = RegistrationQueryResponse.Success(result);
                await mediator.Publish(new RegistrationViewed(request.EssFileNumber, request.Reason));
            }

            return response;
        }

        public async Task<ViewModels.RegistrationSummary> Handle(RegistrationSummaryQueryRequest request, CancellationToken cancellationToken)
        {
            return await dataInterface.GetEvacueeRegistrationSummaryAsync(request.EssFileNumber);
        }
    }

    public class RegistrationQueryRequest : IRequest<RegistrationQueryResponse>
    {
        public RegistrationQueryRequest(string essFileNumber, string reason)
        {
            EssFileNumber = essFileNumber;
            Reason = reason;
        }

        public string EssFileNumber { get; }
        public string Reason { get; }
    }

    public class RegistrationQueryResponse
    {
        public enum ResponseStatus
        {
            Success = 1,
            NotFound,
            Error
        }

        public static RegistrationQueryResponse Success(ViewModels.Registration registration)
        {
            return new RegistrationQueryResponse
            {
                Status = ResponseStatus.Success,
                Registration = registration
            };
        }

        public static RegistrationQueryResponse NotFound(string essFileNumber)
        {
            return new RegistrationQueryResponse
            {
                Status = ResponseStatus.NotFound,
                FailureReason = $"Registration with ESS File Number '{essFileNumber}' not found"
            };
        }

        public static RegistrationQueryResponse Error(string reason)
        {
            return new RegistrationQueryResponse
            {
                Status = ResponseStatus.Error,
                FailureReason = reason
            };
        }

        public ViewModels.Registration Registration { get; private set; }

        public string FailureReason { get; private set; }
        public ResponseStatus Status { get; private set; }
    }

    public class RegistrationSummaryQueryRequest : IRequest<ViewModels.RegistrationSummary>
    {
        public RegistrationSummaryQueryRequest(string essFileNumber)
        {
            EssFileNumber = essFileNumber;
        }

        public string EssFileNumber { get; }
    }

    public class RegistrationViewed : RegistrationEvent
    {
        public string ReasonForView { get; }

        public RegistrationViewed(string essFileNumber, string reasonForView) : base(essFileNumber)
        {
            ReasonForView = reasonForView;
        }
    }
}