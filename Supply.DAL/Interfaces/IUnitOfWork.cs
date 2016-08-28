using System;
using System.Threading.Tasks;
using Supply.DAL.Entities;

namespace Supply.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<Good> GoodRepository { get; }
        IGenericRepository<Supplier> SuppliereRepository { get; }

        Task SaveAsync();
    }
}
