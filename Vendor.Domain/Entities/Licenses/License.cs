using System;
using System.Collections.Generic;
using System.Text;
using Vendor.Domain.Entites.Companies;

namespace Vendor.Domain.Entites.Licenses
{
    public class License
    {
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string UploadLinces { get; set; }
        public long LicenseTypeId { get; set; }
        public string UserId { get; set; }
        public virtual LicenseType LicenseType { get; set; }
        public virtual List<Company> Companies { get; set; }
    }
}
