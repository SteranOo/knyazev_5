using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supply.DAL.Entities;

namespace Supply.DAL.EF
{
    class EFSupplyDbContext : DbContext
    {
        public EFSupplyDbContext() : base("SupplyDbConnectionString") { }
        public EFSupplyDbContext(string conectionString) : base(conectionString) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
