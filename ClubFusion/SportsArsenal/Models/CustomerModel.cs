using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SportsArsenal.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(11)]
        [Index("UniquePhoneNo", 1, IsUnique = true)]
        public string PhoneNo { get; set; }
        [Required]
        [StringLength(11)]
        [Index("UniqueEmailAddress", 2, IsUnique = true)]
        public string Email { get; set; }
        [Required]
        [StringLength(250)]
        public string Address { get; set; }
        [Required]
        public bool isActive { get; set; }

        public int? UpdateBy { get; set; }
    }
}