using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mmenu
    {
        public long? CompanyId { get; set; }
        public long MenuId { get; set; }
        public string Module { get; set; } = null!;
        public string? MenuName { get; set; }
        public string? ParentId { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Tag { get; set; }
    }
}
