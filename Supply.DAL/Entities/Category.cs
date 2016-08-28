using System.ComponentModel.DataAnnotations;

namespace Supply.DAL.Entities
{
    public class Category : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
