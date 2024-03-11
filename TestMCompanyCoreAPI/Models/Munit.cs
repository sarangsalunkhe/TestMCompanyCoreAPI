using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Munit
    {
        public long UnitId { get; set; }
        public string UnitCode { get; set; } = null!;
        public string? UnitName { get; set; }
        public string? AcFlag { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }

        public virtual Muser CreatedByNavigation { get; set; } = null!;
    }
}
