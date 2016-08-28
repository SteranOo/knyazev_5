using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Supply.BLL.DTO
{
    public class SupplierDTO
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public IEnumerable<GoodDTO> Goods { get; set; }
    }
}
