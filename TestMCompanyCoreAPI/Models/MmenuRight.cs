using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class MmenuRight
    {
        public int? MenuId { get; set; }
        public int? Module { get; set; }
        public int? UserId { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
