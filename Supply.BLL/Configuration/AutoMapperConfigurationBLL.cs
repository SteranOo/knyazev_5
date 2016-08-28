using AutoMapper;
using Supply.BLL.DTO;
using Supply.DAL.Entities;

namespace Supply.BLL.Configuration
{
    public static class AutoMapperConfigurationBLL
    {
        public static IMapper Mapper;

        static AutoMapperConfigurationBLL()
        {
            Mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Good, GoodDTO>().ReverseMap();
                cfg.CreateMap<Category, CategoryDTO>().ReverseMap();
                cfg.CreateMap<Supplier, SupplierDTO>().ReverseMap();
            }).CreateMapper();
        }
    }
}
