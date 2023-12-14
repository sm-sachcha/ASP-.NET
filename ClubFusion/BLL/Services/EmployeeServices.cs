using BLL.DTOs;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeServices
    {
        public static List<EmployeeDTO> GetAll()
        {
            var data = DataAccessLayer.EmployeeContent().GetAll();
            return Convert(data);
        }
        public static EmployeeDTO Get(int id)
        {
            var data = DataAccessLayer.EmployeeContent().GetById(id);
            return Convert(data);
        }
        public static int Add(EmployeeDTO employee)
        {
            var data = Convert(employee);
            return DataAccessLayer.EmployeeContent().Insert(data);
        }
        public static int Delete(EmployeeDTO employee)
        {
            var data = Convert(employee);
            return DataAccessLayer.EmployeeContent().Delete(data);
        }
        public static int Edit(EmployeeDTO employee)
        {
            var data = Convert(employee);
            return DataAccessLayer.EmployeeContent().Update(data);
        }

        static List<EmployeeDTO> Convert(List<Employee> emp)
        {
            var data = new List<EmployeeDTO>();
            foreach (Employee x in emp)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<Employee> Convert(List<EmployeeDTO> emp)
        {
            var data = new List<Employee>();
            foreach (EmployeeDTO x in emp)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static Employee Convert(EmployeeDTO employee)
        {
            return new Employee()
            {
                Name = employee.Name,
                EmpId = employee.EmpId,
                PermanentAddress = employee.PermanentAddress,
                DateOfJoining = employee.DateOfJoining,
                DateOfLeaving = employee.DateOfLeaving,
                FatherName = employee.FatherName,
                MotherName = employee.MotherName,
                PassportNo = employee.PassportNo,
                PresentAddress = employee.PresentAddress,
                DepartmentId = employee.DepartmentId,
                GradeId = employee.GradeId,
                TinNo = employee.TinNo,
                DivisionId = employee.DivisionId,
                LocationId = employee.LocationId,
                NidNo = employee.NidNo,
                UnitId = employee.UnitId,
                DesignationId = employee.DesignationId,
                UserId = employee.UserId
            };
        }
        static EmployeeDTO Convert(Employee employee)
        {
            return new EmployeeDTO()
            {
                Id = employee.Id,
                Name = employee.Name,
                EmpId = employee.EmpId,
                PermanentAddress = employee.PermanentAddress,
                DateOfJoining = employee.DateOfJoining,
                DateOfLeaving = employee.DateOfLeaving,
                FatherName = employee.FatherName,
                MotherName = employee.MotherName,
                PassportNo = employee.PassportNo,
                PresentAddress = employee.PresentAddress,
                DepartmentId = employee.DepartmentId,
                GradeId = employee.GradeId,
                TinNo = employee.TinNo,
                DivisionId = employee.DivisionId,
                LocationId = employee.LocationId,
                NidNo = employee.NidNo,
                UnitId = employee.UnitId,
                DesignationId = employee.DesignationId,
                UserId = employee.UserId
            };
        }
    }
}
