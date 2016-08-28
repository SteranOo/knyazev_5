using System.Collections.Generic;
using Supply.BLL.DTO;

namespace Supply.BLL.Interfaces
{
    public interface IGoodService : IService
    {
        List<GoodDTO> GetAllByCategory(CategoryDTO category);
        List<GoodDTO> GetAllBySupplier(SupplierDTO category);
    }
}
