using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public bool isActive { get; set; }
        [Required]
        public DateTime UpdateTime { get; set; }
        public int?  UpdateBy { get; set; }
        [ForeignKey("UpdateBy")]
        public virtual User User { get; set; }
    }
}
