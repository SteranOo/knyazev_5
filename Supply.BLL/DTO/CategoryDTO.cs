using System.ComponentModel.DataAnnotations;

namespace Supply.BLL.DTO
{
    public class CategoryDTO
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
