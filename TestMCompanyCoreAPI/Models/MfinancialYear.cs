using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class MfinancialYear
    {
        public long TrId { get; set; }
        public string FinancialYear { get; set; } = null!;
        public string Fyear { get; set; } = null!;
        public string YearClose { get; set; } = null!;
        public string AcFlag { get; set; } = null!;
    }
}
