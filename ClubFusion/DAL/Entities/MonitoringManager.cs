using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class MonitoringManager
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(7)]
        [Index("UniqueMonitoringManagerId", 1, IsUnique = true)]
        public string MonitoringManagerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(250)]
        public string PermanentAddress { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNo { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        public DateTime? LeavingDate { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [StringLength(10)]
        public string NidNo { get; set; }
        [Required]
        [StringLength(100)]
        public string FatherName { get; set; }
        [Required]
        [StringLength(100)]
        public string MotherName { get; set; }
        [Required]
        public string Gender { get; set; }
        public int? TaskId { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
