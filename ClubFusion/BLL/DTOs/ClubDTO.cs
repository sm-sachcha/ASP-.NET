using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ClubDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(120)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [Required]
        public DateTime UpdateTime { get; set; }
        [Required]
        public bool isActive { get; set; }
        public int? UpdateBy { get; set; }
    }
}
