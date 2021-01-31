using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class LegalEntity
    {
        public int PartnerId { get; set; }
        public string CompanyName { get; set; }
        public string Inn { get; set; }
        public string Kpp { get; set; }
        public string LegalAddress { get; set; }
        public string PostAddress { get; set; }
        public string ActualAddress { get; set; }
        public string SettlementAccount { get; set; }
        public string Bank { get; set; }
        public string CorrespondentAccount { get; set; }
        public string Bik { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public string Director { get; set; }
        public string Accountant { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Zip { get; set; }

        public Partner Partner { get; set; }
    }
}
