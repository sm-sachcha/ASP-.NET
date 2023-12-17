using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductSizeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductMeasurement { get; set; }
        [Required]
        public bool isActive { get; set; }
        [Required]
        public DateTime UpdateTime { get; set; }
        public int? UpdateBy { get; set; }
    }
}
