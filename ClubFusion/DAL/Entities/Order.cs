using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Order
    {
        [Key]
        [Required]
        [StringLength(9)]
        [Index("UniqueOrderId", 1, IsUnique = true)]
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
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("UpdateBy")]
        public virtual User User { get; set; }      
    }
}
