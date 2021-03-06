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
    /// processstage
    /// </summary>
    public partial class MicrosoftDynamicsCRMprocessstage
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprocessstage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprocessstage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMprocessstage
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMprocessstage(long? versionnumber = default(long?), string processstageid = default(string), string stagename = default(string), string _processidValue = default(string), string owningbusinessunit = default(string), int? stagecategory = default(int?), string primaryentitytypecode = default(string), string _owneridValue = default(string), string clientdata = default(string), IList<MicrosoftDynamicsCRMlead> processstageLead = default(IList<MicrosoftDynamicsCRMlead>), IList<MicrosoftDynamicsCRMproduct> processstageProducts = default(IList<MicrosoftDynamicsCRMproduct>), IList<MicrosoftDynamicsCRMproductpricelevel> processstageProductpricelevels = default(IList<MicrosoftDynamicsCRMproductpricelevel>), IList<MicrosoftDynamicsCRMcampaign> processstageCampaigns = default(IList<MicrosoftDynamicsCRMcampaign>), IList<MicrosoftDynamicsCRMcampaignactivity> processstageCampaignactivities = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> processstageCampaignresponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMlist> processstageLists = default(IList<MicrosoftDynamicsCRMlist>), IList<MicrosoftDynamicsCRMincident> processstageIncident = default(IList<MicrosoftDynamicsCRMincident>), IList<MicrosoftDynamicsCRMphonetocaseprocess> processstagePhonetocaseprocess = default(IList<MicrosoftDynamicsCRMphonetocaseprocess>), IList<MicrosoftDynamicsCRMinvoice> processstageInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> processstageLeadtoopportunitysalesprocess = default(IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess>), IList<MicrosoftDynamicsCRMopportunity> processstageOpportunity = default(IList<MicrosoftDynamicsCRMopportunity>), IList<MicrosoftDynamicsCRMopportunitysalesprocess> processstageOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), IList<MicrosoftDynamicsCRMquote> processstageQuotes = default(IList<MicrosoftDynamicsCRMquote>), IList<MicrosoftDynamicsCRMsalesliterature> processstageSalesliteratures = default(IList<MicrosoftDynamicsCRMsalesliterature>), IList<MicrosoftDynamicsCRMsalesorder> processstageSalesorders = default(IList<MicrosoftDynamicsCRMsalesorder>), IList<MicrosoftDynamicsCRMcompetitor> processstageCompetitors = default(IList<MicrosoftDynamicsCRMcompetitor>), IList<MicrosoftDynamicsCRMknowledgearticle> processstageKnowledgearticle = default(IList<MicrosoftDynamicsCRMknowledgearticle>), IList<MicrosoftDynamicsCRMcontact> processstageContact = default(IList<MicrosoftDynamicsCRMcontact>), IList<MicrosoftDynamicsCRMfax> processstageFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMteam> processstageTeams = default(IList<MicrosoftDynamicsCRMteam>), IList<MicrosoftDynamicsCRMsyncerror> processStageSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMletter> processstageLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMappointment> processstageAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMexpiredprocess> processstageExpiredprocess = default(IList<MicrosoftDynamicsCRMexpiredprocess>), IList<MicrosoftDynamicsCRMtask> processstageTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMnewprocess> processstageNewprocess = default(IList<MicrosoftDynamicsCRMnewprocess>), IList<MicrosoftDynamicsCRMphonecall> processstagePhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> processstageRecurringappointmentmasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsystemuser> processstageSystemusers = default(IList<MicrosoftDynamicsCRMsystemuser>), MicrosoftDynamicsCRMworkflow processid = default(MicrosoftDynamicsCRMworkflow), IList<MicrosoftDynamicsCRMemail> processstageEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMtranslationprocess> processstageTranslationprocess = default(IList<MicrosoftDynamicsCRMtranslationprocess>), IList<MicrosoftDynamicsCRMaccount> processstageAccount = default(IList<MicrosoftDynamicsCRMaccount>))
        {
            Versionnumber = versionnumber;
            Processstageid = processstageid;
            Stagename = stagename;
            this._processidValue = _processidValue;
            Owningbusinessunit = owningbusinessunit;
            Stagecategory = stagecategory;
            Primaryentitytypecode = primaryentitytypecode;
            this._owneridValue = _owneridValue;
            Clientdata = clientdata;
            ProcessstageLead = processstageLead;
            ProcessstageProducts = processstageProducts;
            ProcessstageProductpricelevels = processstageProductpricelevels;
            ProcessstageCampaigns = processstageCampaigns;
            ProcessstageCampaignactivities = processstageCampaignactivities;
            ProcessstageCampaignresponses = processstageCampaignresponses;
            ProcessstageLists = processstageLists;
            ProcessstageIncident = processstageIncident;
            ProcessstagePhonetocaseprocess = processstagePhonetocaseprocess;
            ProcessstageInvoices = processstageInvoices;
            ProcessstageLeadtoopportunitysalesprocess = processstageLeadtoopportunitysalesprocess;
            ProcessstageOpportunity = processstageOpportunity;
            ProcessstageOpportunitysalesprocess = processstageOpportunitysalesprocess;
            ProcessstageQuotes = processstageQuotes;
            ProcessstageSalesliteratures = processstageSalesliteratures;
            ProcessstageSalesorders = processstageSalesorders;
            ProcessstageCompetitors = processstageCompetitors;
            ProcessstageKnowledgearticle = processstageKnowledgearticle;
            ProcessstageContact = processstageContact;
            ProcessstageFaxes = processstageFaxes;
            ProcessstageTeams = processstageTeams;
            ProcessStageSyncErrors = processStageSyncErrors;
            ProcessstageLetters = processstageLetters;
            ProcessstageAppointments = processstageAppointments;
            ProcessstageExpiredprocess = processstageExpiredprocess;
            ProcessstageTasks = processstageTasks;
            ProcessstageNewprocess = processstageNewprocess;
            ProcessstagePhonecalls = processstagePhonecalls;
            ProcessstageRecurringappointmentmasters = processstageRecurringappointmentmasters;
            ProcessstageSystemusers = processstageSystemusers;
            Processid = processid;
            ProcessstageEmails = processstageEmails;
            ProcessstageTranslationprocess = processstageTranslationprocess;
            ProcessstageAccount = processstageAccount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstageid")]
        public string Processstageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagename")]
        public string Stagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_processid_value")]
        public string _processidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public string Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stagecategory")]
        public int? Stagecategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentitytypecode")]
        public string Primaryentitytypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientdata")]
        public string Clientdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_lead")]
        [NotMapped] public IList<MicrosoftDynamicsCRMlead> ProcessstageLead { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_products")]
        [NotMapped] public IList<MicrosoftDynamicsCRMproduct> ProcessstageProducts { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_productpricelevels")]
        [NotMapped] public IList<MicrosoftDynamicsCRMproductpricelevel> ProcessstageProductpricelevels { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaigns")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcampaign> ProcessstageCampaigns { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaignactivities")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcampaignactivity> ProcessstageCampaignactivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_campaignresponses")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcampaignresponse> ProcessstageCampaignresponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_lists")]
        [NotMapped] public IList<MicrosoftDynamicsCRMlist> ProcessstageLists { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_incident")]
        [NotMapped] public IList<MicrosoftDynamicsCRMincident> ProcessstageIncident { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_phonetocaseprocess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonetocaseprocess> ProcessstagePhonetocaseprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_invoices")]
        [NotMapped] public IList<MicrosoftDynamicsCRMinvoice> ProcessstageInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_leadtoopportunitysalesprocess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMleadtoopportunitysalesprocess> ProcessstageLeadtoopportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_opportunity")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunity> ProcessstageOpportunity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_opportunitysalesprocess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMopportunitysalesprocess> ProcessstageOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_quotes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMquote> ProcessstageQuotes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_salesliteratures")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsalesliterature> ProcessstageSalesliteratures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_salesorders")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsalesorder> ProcessstageSalesorders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_competitors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcompetitor> ProcessstageCompetitors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_knowledgearticle")]
        [NotMapped] public IList<MicrosoftDynamicsCRMknowledgearticle> ProcessstageKnowledgearticle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_contact")]
        [NotMapped] public IList<MicrosoftDynamicsCRMcontact> ProcessstageContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_faxes")]
        [NotMapped] public IList<MicrosoftDynamicsCRMfax> ProcessstageFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_teams")]
        [NotMapped] public IList<MicrosoftDynamicsCRMteam> ProcessstageTeams { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ProcessStage_SyncErrors")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsyncerror> ProcessStageSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_letters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMletter> ProcessstageLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_appointments")]
        [NotMapped] public IList<MicrosoftDynamicsCRMappointment> ProcessstageAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_expiredprocess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMexpiredprocess> ProcessstageExpiredprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_tasks")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtask> ProcessstageTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_newprocess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMnewprocess> ProcessstageNewprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_phonecalls")]
        [NotMapped] public IList<MicrosoftDynamicsCRMphonecall> ProcessstagePhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_recurringappointmentmasters")]
        [NotMapped] public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> ProcessstageRecurringappointmentmasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_systemusers")]
        [NotMapped] public IList<MicrosoftDynamicsCRMsystemuser> ProcessstageSystemusers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public MicrosoftDynamicsCRMworkflow Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_emails")]
        [NotMapped] public IList<MicrosoftDynamicsCRMemail> ProcessstageEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_translationprocess")]
        [NotMapped] public IList<MicrosoftDynamicsCRMtranslationprocess> ProcessstageTranslationprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processstage_account")]
        [NotMapped] public IList<MicrosoftDynamicsCRMaccount> ProcessstageAccount { get; set; }

    }
}
