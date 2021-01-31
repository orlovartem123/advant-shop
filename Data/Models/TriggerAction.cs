using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class TriggerAction
    {
        public TriggerAction()
        {
            TriggerDeferredData = new HashSet<TriggerDeferredData>();
        }

        public int Id { get; set; }
        public int TriggerRuleId { get; set; }
        public int ActionType { get; set; }
        public string TimeDelay { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string SmsText { get; set; }
        public Guid EmailingId { get; set; }
        public string EditFieldValue { get; set; }
        public int? EditFieldType { get; set; }
        public int? ObjId { get; set; }
        public int? SmartCallsCampaignId { get; set; }
        public int? DealStatusId { get; set; }
        public int? RequestMethod { get; set; }
        public string RequestUrl { get; set; }
        public string RequestParams { get; set; }
        public string RequestHeaderParams { get; set; }
        public int? SortOrder { get; set; }
        public int? RequestParamsType { get; set; }
        public string RequestParamsJson { get; set; }

        public TriggerRule TriggerRule { get; set; }
        public ICollection<TriggerDeferredData> TriggerDeferredData { get; set; }
    }
}
