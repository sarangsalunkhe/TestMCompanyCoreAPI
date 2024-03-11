using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class MopningBalnce
    {
        public long Tid { get; set; }
        public long CompanyId { get; set; }
        public string Module { get; set; } = null!;
        public string Tcode { get; set; } = null!;
        public long CustomerId { get; set; }
        public string? AcType { get; set; }
        public string Fyear { get; set; } = null!;
        public decimal? OpeningBal { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
        public long? ProductTypeId { get; set; }
    }
}
