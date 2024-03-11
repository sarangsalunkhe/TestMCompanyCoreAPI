using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Mexpense
    {
        public long ExpenseId { get; set; }
        public long CompanyId { get; set; }
        public string Module { get; set; } = null!;
        public string ExpenseCode { get; set; } = null!;
        public string? ExpenseName { get; set; }
        public string? Specification { get; set; }
        public decimal? MaxLimit { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? Remark { get; set; }
        public string? ProductionFlag { get; set; }
        public string? BatchExpense { get; set; }

        public virtual Muser? CreatedByNavigation { get; set; }
    }
}
