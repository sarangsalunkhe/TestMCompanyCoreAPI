using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mpacking
    {
        public long PackingId { get; set; }
        public string PackingCode { get; set; } = null!;
        public string? PackingName { get; set; }
        public string? AcFlag { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
    }
}
