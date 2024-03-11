using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class VdailyExpenseDetail
    {
        public string DailyExpenseId { get; set; } = null!;
        public long? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? Specification { get; set; }
        public string? CompanyAdddess { get; set; }
        public byte[]? Logo { get; set; }
        public string? EmailId { get; set; }
        public string? CellNo { get; set; }
        public string? PhoneNo { get; set; }
        public string Fyear { get; set; } = null!;
        public long? ExpenseId { get; set; }
        public string? ExpenseName { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? TotalAmt { get; set; }
        public string? Purpose { get; set; }
    }
}
