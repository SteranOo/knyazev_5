using System.ComponentModel.DataAnnotations;

namespace Supply.DAL.Entities
{
    public class Good : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Discription { get; set; }

        public virtual Category Category { get; set; }
    }
}
