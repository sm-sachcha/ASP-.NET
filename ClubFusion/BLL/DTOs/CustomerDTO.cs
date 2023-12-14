using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomerDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        public bool isActive { get; set; }
        public int ClubId { get; set; }
    }
}
