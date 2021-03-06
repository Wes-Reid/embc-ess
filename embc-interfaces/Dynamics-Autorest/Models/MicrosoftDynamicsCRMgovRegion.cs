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
    /// gov_region
    /// </summary>
    public partial class MicrosoftDynamicsCRMgovRegion
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMgovRegion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMgovRegion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMgovRegion
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMgovRegion(string govName = default(string), string _govEmbcrepresentativeidValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string govPhone = default(string), int? timezoneruleversionnumber = default(int?), string _organizationidValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _govPrimarycontactidValue = default(string), int? importsequencenumber = default(int?), long? versionnumber = default(long?), string _createdbyValue = default(string), string govEmail = default(string), string govRegionid = default(string), string _createdonbehalfbyValue = default(string), int? statecode = default(int?), IList<MicrosoftDynamicsCRMgovIncidenttask> govRegionIncidenttasks = default(IList<MicrosoftDynamicsCRMgovIncidenttask>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> govRegionSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> govRegionDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> govRegionDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> govRegionAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> govRegionMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> govRegionProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> govRegionBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> govRegionPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMannotation> govRegionAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMgovCommunity> govRegionCommunities = default(IList<MicrosoftDynamicsCRMgovCommunity>), IList<MicrosoftDynamicsCRMequipment> govRegionFacilities = default(IList<MicrosoftDynamicsCRMequipment>), IList<MicrosoftDynamicsCRMgovRegistration> govRegionRegistrations = default(IList<MicrosoftDynamicsCRMgovRegistration>), MicrosoftDynamicsCRMsystemuser govEMBCRepresentativeId = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMcontact govPrimaryContactId = default(MicrosoftDynamicsCRMcontact), IList<MicrosoftDynamicsCRMcontact> govRegionEvacueecontacts = default(IList<MicrosoftDynamicsCRMcontact>))
        {
            GovName = govName;
            this._govEmbcrepresentativeidValue = _govEmbcrepresentativeidValue;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            GovPhone = govPhone;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._organizationidValue = _organizationidValue;
            Overriddencreatedon = overriddencreatedon;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            Createdon = createdon;
            this._govPrimarycontactidValue = _govPrimarycontactidValue;
            Importsequencenumber = importsequencenumber;
            Versionnumber = versionnumber;
            this._createdbyValue = _createdbyValue;
            GovEmail = govEmail;
            GovRegionid = govRegionid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            GovRegionIncidenttasks = govRegionIncidenttasks;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            GovRegionSyncErrors = govRegionSyncErrors;
            GovRegionDuplicateMatchingRecord = govRegionDuplicateMatchingRecord;
            GovRegionDuplicateBaseRecord = govRegionDuplicateBaseRecord;
            GovRegionAsyncOperations = govRegionAsyncOperations;
            GovRegionMailboxTrackingFolders = govRegionMailboxTrackingFolders;
            GovRegionProcessSession = govRegionProcessSession;
            GovRegionBulkDeleteFailures = govRegionBulkDeleteFailures;
            GovRegionPrincipalObjectAttributeAccesses = govRegionPrincipalObjectAttributeAccesses;
            GovRegionAnnotations = govRegionAnnotations;
            GovRegionCommunities = govRegionCommunities;
            GovRegionFacilities = govRegionFacilities;
            GovRegionRegistrations = govRegionRegistrations;
            GovEMBCRepresentativeId = govEMBCRepresentativeId;
            GovPrimaryContactId = govPrimaryContactId;
            GovRegionEvacueecontacts = govRegionEvacueecontacts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_name")]
        public string GovName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_embcrepresentativeid_value")]
        public string _govEmbcrepresentativeidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_phone")]
        public string GovPhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_gov_primarycontactid_value")]
        public string _govPrimarycontactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_email")]
        public string GovEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_regionid")]
        public string GovRegionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_incidenttasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovIncidenttask> GovRegionIncidenttasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> GovRegionSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_DuplicateMatchingRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> GovRegionDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_DuplicateBaseRecord")]
        [NotMapped] public IList<MicrosoftDynamicsCRMduplicaterecord> GovRegionDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_AsyncOperations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMasyncoperation> GovRegionAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_MailboxTrackingFolders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> GovRegionMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_ProcessSession")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprocesssession> GovRegionProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_BulkDeleteFailures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMbulkdeletefailure> GovRegionBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_PrincipalObjectAttributeAccesses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> GovRegionPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_Annotations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMannotation> GovRegionAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_communities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovCommunity> GovRegionCommunities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_facilities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMequipment> GovRegionFacilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_registrations")]
        [NotMapped] public IList<MicrosoftDynamicsCRMgovRegistration> GovRegionRegistrations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_EMBCRepresentativeId")]
        public MicrosoftDynamicsCRMsystemuser GovEMBCRepresentativeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_PrimaryContactId")]
        public MicrosoftDynamicsCRMcontact GovPrimaryContactId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "gov_region_evacueecontacts")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> GovRegionEvacueecontacts { get; set; }

    }
}
