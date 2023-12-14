using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [StringLength(6)]
        [Index("UniqueEmployeeId", 1, IsUnique = true)]
        public string EmpId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string FatherName { get; set; }
        [Required]
        [StringLength(100)]
        public string MotherName { get; set; }
        [Required]
        [StringLength(200)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(200)]
        public string PermanentAddress { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        public DateTime? DateOfLeaving { get; set; }
        public int GradeId { get; set; }
        public int DesignationId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int DivisionId { get; set; }
        public int LocationId { get; set; }
        [StringLength(10)]
        [Index("UniqueNidNo", 2, IsUnique = true)]
        public string NidNo { get; set; }
        [StringLength(30)]
        [Index("UniquePassportNo", 3, IsUnique = true)]
        public string PassportNo { get; set; }
        [StringLength(30)]
        [Index("UniqueTinNo", 4, IsUnique = true)]
        public string TinNo { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }
        [ForeignKey("DivisionId")]
        public virtual Division Division { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }
        [ForeignKey("GradeId")]
        public virtual ProductGrade ProductGrade { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
