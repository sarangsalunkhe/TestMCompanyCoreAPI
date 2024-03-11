using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mmaterial
    {
        public long MaterialId { get; set; }
        public string MaterialCode { get; set; } = null!;
        public string? MaterialName { get; set; }
        public long? MatrialUnit { get; set; }
        public long? PackingId { get; set; }
        public string? ForCasteFlag { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
    }
}
