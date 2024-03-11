using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Msupplier
    {
        public long SupplierId { get; set; }
        public string SupplierCode { get; set; } = null!;
        public string BrokeragePer { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string SupplierAddress { get; set; } = null!;
        public string PhoneNo { get; set; } = null!;
        public string? CellNo { get; set; }
        public string? Vatno { get; set; }
        public string? Cstno { get; set; }
        public string? Bstno { get; set; }
        public string? Panno { get; set; }
        public string? Tanno { get; set; }
        public string? EmailId { get; set; }
        public string? Faxno { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
        public string? AccountNo { get; set; }
        public string? BankName { get; set; }
        public string? BranchName { get; set; }
        public string? BankAddress { get; set; }

        public virtual Muser? CreatedByNavigation { get; set; }
    }
}
