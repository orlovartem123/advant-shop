using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerField
    {
        public CustomerField()
        {
            CustomerFieldValue = new HashSet<CustomerFieldValue>();
            CustomerFieldValuesMap = new HashSet<CustomerFieldValuesMap>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FieldType { get; set; }
        public int SortOrder { get; set; }
        public bool Required { get; set; }
        public bool Enabled { get; set; }
        public bool ShowInRegistration { get; set; }
        public bool ShowInCheckout { get; set; }
        public bool DisableCustomerEditing { get; set; }

        public ICollection<CustomerFieldValue> CustomerFieldValue { get; set; }
        public ICollection<CustomerFieldValuesMap> CustomerFieldValuesMap { get; set; }
    }
}
