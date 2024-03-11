using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class VsupplierOutStanding
    {
        public long CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAdddess { get; set; }
        public string? PhoneNo { get; set; }
        public string? CellNo { get; set; }
        public string? EmailId { get; set; }
        public string? Panno { get; set; }
        public string Fyear { get; set; } = null!;
        public string ContractNo { get; set; } = null!;
        public DateTime ContractDate { get; set; }
        public string? SupplierName { get; set; }
        public decimal TotalAmount { get; set; }
        public string? SupplierBillNo { get; set; }
        public DateTime? SupplierBillDate { get; set; }
        public decimal BillQuantity { get; set; }
        public decimal BillAmount { get; set; }
        public decimal? BrokeragePercent { get; set; }
        public decimal BrokerageAmount { get; set; }
        public string? PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? SupBrokrageReceived { get; set; }
        public string? SupPaidFlag { get; set; }
        public decimal DeductionAmount { get; set; }
    }
}
