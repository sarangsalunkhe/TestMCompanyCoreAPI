using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mcompany
    {
        public long CompanyId { get; set; }
        public string CompanyCode { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CompanyAdddess { get; set; } = null!;
        public string? PhoneNo { get; set; }
        public string? CellNo { get; set; }
        public string? EmailId { get; set; }
        public string? Panno { get; set; }
        public string? Cst { get; set; }
        public string? Bst { get; set; }
        public byte[]? Logo { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
        public string? TallyId { get; set; }
    }
}
