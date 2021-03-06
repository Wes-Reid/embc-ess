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
    /// LookupEntityMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMLookupEntityMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupEntityMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupEntityMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMLookupEntityMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMLookupEntityMetadata(bool? isReadOnlyInMobileClient = default(bool?), bool? isEnabledInUnifiedInterface = default(bool?), string displayName = default(string), string primaryNameAttribute = default(string), string primaryIdAttribute = default(string), string logicalName = default(string), string displayCollectionName = default(string), string iconVectorName = default(string))
        {
            IsReadOnlyInMobileClient = isReadOnlyInMobileClient;
            IsEnabledInUnifiedInterface = isEnabledInUnifiedInterface;
            DisplayName = displayName;
            PrimaryNameAttribute = primaryNameAttribute;
            PrimaryIdAttribute = primaryIdAttribute;
            LogicalName = logicalName;
            DisplayCollectionName = displayCollectionName;
            IconVectorName = iconVectorName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadOnlyInMobileClient")]
        public bool? IsReadOnlyInMobileClient { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabledInUnifiedInterface")]
        public bool? IsEnabledInUnifiedInterface { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryNameAttribute")]
        public string PrimaryNameAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryIdAttribute")]
        public string PrimaryIdAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LogicalName")]
        public string LogicalName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayCollectionName")]
        public string DisplayCollectionName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconVectorName")]
        public string IconVectorName { get; set; }

    }
}
