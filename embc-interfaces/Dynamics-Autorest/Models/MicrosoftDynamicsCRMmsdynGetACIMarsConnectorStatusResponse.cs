// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// msdyn_GetACIMarsConnectorStatusResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynGetACIMarsConnectorStatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynGetACIMarsConnectorStatusResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynGetACIMarsConnectorStatusResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynGetACIMarsConnectorStatusResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynGetACIMarsConnectorStatusResponse(string marsStatus = default(string))
        {
            MarsStatus = marsStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MarsStatus")]
        public string MarsStatus { get; set; }

    }
}
