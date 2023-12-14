using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TaskDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        [Required]
        public DateTime UpdateTime { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public int? UpdateBy { get; set; }
        public int? LocationId { get; set; }
    }
}
