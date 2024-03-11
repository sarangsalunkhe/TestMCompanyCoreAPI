using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class VbillEntry
    {
        public string CompanyName { get; set; } = null!;
        public string CompanyAdddess { get; set; } = null!;
        public string? PhoneNo { get; set; }
        public string? CellNo { get; set; }
        public string? EmailId { get; set; }
        public long SupplierId { get; set; }
        public string BrokeragePer { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public string SupplierAddress { get; set; } = null!;
        public string SupPhoneNo { get; set; } = null!;
        public string? SupCellNo { get; set; }
        public long MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string CustPhoneNo { get; set; } = null!;
        public string? CustCellNo { get; set; }
        public string ContractNo { get; set; } = null!;
        public DateTime ContractDate { get; set; }
        public string BillNo { get; set; } = null!;
        public DateTime BillDate { get; set; }
        public decimal BillQty { get; set; }
        public decimal BillAmount { get; set; }
        public decimal? SupBrokragePercent { get; set; }
        public decimal? CustBrokragePercent { get; set; }
        public decimal? ContractQty { get; set; }
        public long CustomerId { get; set; }
        public byte[]? Logo { get; set; }
        public string? CheckFlag { get; set; }
        public string? Panno { get; set; }
        public string Expr1 { get; set; } = null!;
    }
}
