using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ClubManagerDTO
    {
        [Required]
        [StringLength(6)]
        public string ClubManagerId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int ClubId { get; set; }
        [Key]
        public int UserId { get; set; }
    }
}
