using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class SalesFunnel
    {
        public SalesFunnel()
        {
            LeadField = new HashSet<LeadField>();
            SalesFunnelDealStatus = new HashSet<SalesFunnelDealStatus>();
            SalesFunnelLeadAutoCompleteCategory = new HashSet<SalesFunnelLeadAutoCompleteCategory>();
            SalesFunnelLeadAutoCompleteProduct = new HashSet<SalesFunnelLeadAutoCompleteProduct>();
            SalesFunnelManager = new HashSet<SalesFunnelManager>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public int FinalSuccessAction { get; set; }
        public bool? NotSendNotificationsOnLeadCreation { get; set; }
        public bool Enable { get; set; }
        public bool? NotSendNotificationsOnLeadChanged { get; set; }
        public int LeadAutoCompleteActionType { get; set; }

        public ICollection<LeadField> LeadField { get; set; }
        public ICollection<SalesFunnelDealStatus> SalesFunnelDealStatus { get; set; }
        public ICollection<SalesFunnelLeadAutoCompleteCategory> SalesFunnelLeadAutoCompleteCategory { get; set; }
        public ICollection<SalesFunnelLeadAutoCompleteProduct> SalesFunnelLeadAutoCompleteProduct { get; set; }
        public ICollection<SalesFunnelManager> SalesFunnelManager { get; set; }
    }
}
