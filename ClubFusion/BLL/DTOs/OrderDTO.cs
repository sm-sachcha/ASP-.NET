using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        [Required]
        [StringLength(9)]
        public string OdrId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int UpdateBy { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
        [Required]
        public DateTime UpdateTime { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
    }
}
