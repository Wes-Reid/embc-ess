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
    /// msdyn_QueryExchangeResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMmsdynQueryExchangeResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynQueryExchangeResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynQueryExchangeResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmsdynQueryExchangeResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMmsdynQueryExchangeResponse(string exchangeData = default(string))
        {
            ExchangeData = exchangeData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExchangeData")]
        public string ExchangeData { get; set; }

    }
}
