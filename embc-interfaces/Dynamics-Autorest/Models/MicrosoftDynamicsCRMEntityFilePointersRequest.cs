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
    /// EntityFilePointersRequest
    /// </summary>
    public partial class MicrosoftDynamicsCRMEntityFilePointersRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEntityFilePointersRequest class.
        /// </summary>
        public MicrosoftDynamicsCRMEntityFilePointersRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEntityFilePointersRequest class.
        /// </summary>
        public MicrosoftDynamicsCRMEntityFilePointersRequest(int? objectTypeCode = default(int?), IList<string> filePointers = default(IList<string>))
        {
            ObjectTypeCode = objectTypeCode;
            FilePointers = filePointers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ObjectTypeCode")]
        public int? ObjectTypeCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilePointers")]
        [NotMapped] public IList<string> FilePointers { get; set; }

    }
}
