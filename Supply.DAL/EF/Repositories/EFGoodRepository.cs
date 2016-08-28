using System.Data.Entity;
using Supply.DAL.Entities;

namespace Supply.DAL.EF.Repositories
{
    public class EFGoodRepository: EFGenericRepository<Good>
    {
        public EFGoodRepository(DbContext context) : base(context)
        {
        }
    }
}
