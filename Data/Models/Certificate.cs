using System;
using System.Collections.Generic;

namespace AdvantShop.Data.Models
{
    public partial class Certificate
    {
        public Certificate()
        {
            CustomerCertificate = new HashSet<CustomerCertificate>();
        }

        public int CertificateId { get; set; }
        public string CertificateCode { get; set; }
        public int? OrderId { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public double Sum { get; set; }
        public string Message { get; set; }
        public bool Used { get; set; }
        public bool Enable { get; set; }
        public string ToEmail { get; set; }
        public DateTime CreationDate { get; set; }
        public string ApplyOrderNumber { get; set; }

        public Certificate CertificateNavigation { get; set; }
        public Order Order { get; set; }
        public Certificate InverseCertificateNavigation { get; set; }
        public ICollection<CustomerCertificate> CustomerCertificate { get; set; }
    }
}
