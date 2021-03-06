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
    /// msdyn_RetrieveKPIvaluesfromDCIResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynRetrieveKPIvaluesfromDCIResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRetrieveKPIvaluesfromDCIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRetrieveKPIvaluesfromDCIResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynRetrieveKPIvaluesfromDCIResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynRetrieveKPIvaluesfromDCIResponse(string kPIValues = default(string), string errors = default(string))
        {
            KPIValues = kPIValues;
            Errors = errors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KPIValues")]
        public string KPIValues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Errors")]
        public string Errors { get; set; }

    }
}
