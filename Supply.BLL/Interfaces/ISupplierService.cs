using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Supply.BLL.DTO;

namespace Supply.BLL.Interfaces
{
    public interface ISupplierService : IService
    {
        List<SupplierDTO> GetAllByCategory(CategoryDTO category);
        List<SupplierDTO> GetWidest(CategoryDTO category);
        List<SupplierDTO> GetBy(Expression<Func<SupplierDTO, bool>> predicate);
    }
}
