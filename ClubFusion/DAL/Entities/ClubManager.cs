using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ClubManager
    {
        [Required]
        [StringLength(6)]
        [Index("UniqueClubManagerId", 1, IsUnique = true)]
        public string ClubManagerId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int ClubId { get; set; }
        [Key]
        public int UserId { get; set; }
        [ForeignKey("ClubId")]
        public virtual Club Club { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
