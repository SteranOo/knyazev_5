using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Supply.DAL.Entities
{
    public class Supplier : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public virtual IEnumerable<Good> Goods { get; set; } // = new List<Good>();
    }
}
