using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mcustomer
    {
        public long CustomerId { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string BrokeragePer { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string PhoneNo { get; set; } = null!;
        public string? CellNo { get; set; }
        public long? BankId { get; set; }
        public string? AccountNo { get; set; }
        public string? Ifsccode { get; set; }
        public string? Vatno { get; set; }
        public string? Cstno { get; set; }
        public string? Bstno { get; set; }
        public string? Panno { get; set; }
        public string? Tanno { get; set; }
        public string? EmailId { get; set; }
        public string? Faxno { get; set; }
        public string? ContactPerson { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
        public string BankName { get; set; } = null!;
        public string BranchName { get; set; } = null!;
        public string BankAddress { get; set; } = null!;

        public virtual Muser? CreatedByNavigation { get; set; }
    }
}
