// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Embc.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq; using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// RetrieveParsedDataImportFileResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMRetrieveParsedDataImportFileResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveParsedDataImportFileResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveParsedDataImportFileResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMRetrieveParsedDataImportFileResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMRetrieveParsedDataImportFileResponse(IList<MicrosoftDynamicsCRMStringCollection> values = default(IList<MicrosoftDynamicsCRMStringCollection>))
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        [NotMapped] public IList<MicrosoftDynamicsCRMStringCollection> Values { get; set; }

    }
}
