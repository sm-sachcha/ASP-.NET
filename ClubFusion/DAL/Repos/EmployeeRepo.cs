using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class EmployeeRepo : Repository, IRepository<Employee, int, int, Employee>
    {
        public int Delete(Employee obj)
        {
            var data = cfContext.Employees.Find(obj.EmpId);
            cfContext.Employees.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return cfContext.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return cfContext.Employees.Find(id);
        }

        public int Insert(Employee obj)
        {
            cfContext.Employees.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Employee obj)
        {
            var data = cfContext.Employees.Find(obj.EmpId);
            data.Name = obj.Name;
            data.FatherName = obj.FatherName;
            data.MotherName = obj.MotherName;
            data.PresentAddress = obj.PresentAddress;
            data.PermanentAddress = obj.PermanentAddress;
            data.DateOfJoining = obj.DateOfJoining;
            data.DateOfLeaving = obj.DateOfLeaving;
            data.GradeId = obj.GradeId;
            data.DepartmentId = obj.DepartmentId;
            data.DesignationId = obj.DesignationId;
            data.UnitId = obj.UnitId;
            data.DivisionId = obj.DivisionId;
            data.LocationId = obj.LocationId;
            data.NidNo = obj.NidNo;
            data.PassportNo = obj.PassportNo;
            data.TinNo = obj.TinNo;
            data.UserId = obj.UserId;

            return cfContext.SaveChanges();
        }
    }
}
