using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supply.DAL.Entities;

namespace Supply.DAL.EF.Repositories
{
    public class EFSupplierRepository : EFGenericRepository<Supplier>
    {
        public EFSupplierRepository(DbContext context) : base(context)
        {
        }
    }
}
