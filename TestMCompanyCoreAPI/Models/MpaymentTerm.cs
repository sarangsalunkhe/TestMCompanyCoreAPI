using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class MpaymentTerm
    {
        public long PaymentTermId { get; set; }
        public string PaymentTermCode { get; set; } = null!;
        public string? PaymentTermDescription { get; set; }
        public string? Days { get; set; }
        public string? AcFlag { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remarks { get; set; }
    }
}
