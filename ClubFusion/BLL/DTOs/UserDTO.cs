using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNo { get; set; }
        [StringLength(60)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string BloodGroup { get; set; }
        public string Image { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime UpdateTime { get; set; }
        [Required]
        public bool isActive { get; set; }
        public int UpdateBy { get; set; }
        [Required]
        public int UserType { get; set; }
    }
}
