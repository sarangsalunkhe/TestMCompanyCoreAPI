using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mpoterm
    {
        public long PotermsId { get; set; }
        public long CompanyId { get; set; }
        public string Module { get; set; } = null!;
        public string PotermsCode { get; set; } = null!;
        public string? PotermsName { get; set; }
        public string? Description { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }

        public virtual Muser? CreatedByNavigation { get; set; }
    }
}
