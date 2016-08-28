using System.ComponentModel.DataAnnotations;

namespace Supply.BLL.DTO
{
    public class GoodDTO
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Discription { get; set; }

        public CategoryDTO Category { get; set; }
    }
}
