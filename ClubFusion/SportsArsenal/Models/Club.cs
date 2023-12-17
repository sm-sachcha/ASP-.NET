using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportsArsenal.Models
{
    public class Club
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