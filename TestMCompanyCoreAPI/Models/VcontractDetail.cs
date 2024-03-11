using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class VcontractDetail
    {
        public long CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAdddess { get; set; }
        public string? PhoneNo { get; set; }
        public string? CellNo { get; set; }
        public string? EmailId { get; set; }
        public string? PanNo { get; set; }
        public string Fyear { get; set; } = null!;
        public string ContractNo { get; set; } = null!;
        public DateTime ContractDate { get; set; }
        public long SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupCellNo { get; set; }
        public string? SupEmail { get; set; }
        public string? SuppPhone { get; set; }
        public long CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustCellNo { get; set; }
        public string? CustEmail { get; set; }
        public string? CustPhone { get; set; }
        public string DeliveryType { get; set; } = null!;
        public string DeliveryPlace { get; set; } = null!;
        public int DeliveryDays { get; set; }
        public string? PaymentDays { get; set; }
        public decimal BasicAmount { get; set; }
        public string? OtherRemark { get; set; }
        public string? Poterms { get; set; }
        public int? SrNo { get; set; }
        public long? MaterialId { get; set; }
        public string? MaterialName { get; set; }
        public long? MatrialUnit { get; set; }
        public string? UnitName { get; set; }
        public string? PackingName { get; set; }
        public decimal? ContractQty { get; set; }
        public decimal? ContractRate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? StBagWt { get; set; }
        public byte[]? Logo { get; set; }
        public string? SupplierBillNo { get; set; }
        public DateTime? SupplierBillDate { get; set; }
        public decimal? BillQty { get; set; }
        public decimal? BillAmount { get; set; }
    }
}
