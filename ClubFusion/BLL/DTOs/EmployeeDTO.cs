using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        [StringLength(6)]
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
        public string NidNo { get; set; }
        [StringLength(30)]
        public string PassportNo { get; set; }
        [StringLength(30)]
        public string TinNo { get; set; }
        public int UserId { get; set; }
    }
}
