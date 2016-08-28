using System;
using System.Data.Entity;
using System.Threading.Tasks;
using Supply.DAL.EF.Repositories;
using Supply.DAL.Entities;
using Supply.DAL.Interfaces;

namespace Supply.DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public IGenericRepository<Category> CategoryRepository { get; }
        public IGenericRepository<Good> GoodRepository { get; }
        public IGenericRepository<Supplier> SuppliereRepository { get; }

        private bool _isDisposed;

        public EFUnitOfWork()
        {
            _dbContext = new EFSupplyDbContext();

            CategoryRepository = new EFCategoryRepository(_dbContext);
            GoodRepository = new EFGoodRepository(_dbContext);
            GoodRepository = new EFGoodRepository(_dbContext);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
                _isDisposed = true;
            }
        }

        ~EFUnitOfWork()
        {
            Dispose(false);
        }
    }
}
