using System;
using System.Collections.Generic;

namespace TestMCompanyCoreAPI.Models
{
    public partial class Muser
    {
        public Muser()
        {
            Mcustomers = new HashSet<Mcustomer>();
            Mexpenses = new HashSet<Mexpense>();
            Mpoterms = new HashSet<Mpoterm>();
            Msuppliers = new HashSet<Msupplier>();
            Munits = new HashSet<Munit>();
        }

        public long CompanyId { get; set; }
        public string Module { get; set; } = null!;
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserPwd { get; set; }
        public string? UserType { get; set; }
        public string? AcFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<Mcustomer> Mcustomers { get; set; }
        public virtual ICollection<Mexpense> Mexpenses { get; set; }
        public virtual ICollection<Mpoterm> Mpoterms { get; set; }
        public virtual ICollection<Msupplier> Msuppliers { get; set; }
        public virtual ICollection<Munit> Munits { get; set; }
    }
}
