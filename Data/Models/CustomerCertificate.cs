using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class CustomerCertificate
    {
        public Guid CustomerId { get; set; }
        public int CertificateId { get; set; }

        public Certificate Certificate { get; set; }
    }
}
