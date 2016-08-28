using System.Data.Entity;
using Supply.DAL.Entities;

namespace Supply.DAL.EF.Repositories
{
    public class EFCategoryRepository:EFGenericRepository<Category>
    {
        public EFCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
