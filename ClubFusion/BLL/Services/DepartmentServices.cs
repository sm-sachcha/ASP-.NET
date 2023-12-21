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
    public class DepartmentServices
    {
        public static List<DepartmentDTO> GetAll()
        {
            var data = DataAccessLayer.DepartmentContent().GetAll();
            return Convert(data);
        }

        private static List<DepartmentDTO> Convert(List<Department> departments)
        {
            var data = new List<DepartmentDTO>();
            foreach(Department x in departments)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        public static int Add(DepartmentDTO department)
        {
            var existingClub = DataAccessLayer.DepartmentContent().GetAll().FirstOrDefault(c => c.Name.Equals(department.Name, StringComparison.OrdinalIgnoreCase));

            if (existingClub != null)
            {
                throw new InvalidOperationException("Club with the same name already exists");
            }

            var data = Convert(department);
            return DataAccessLayer.DepartmentContent().Insert(data);
        }

        public static int Edit(DepartmentDTO department)
        {
            if (!department.isActive)
            {
                throw new InvalidOperationException("Can't edit an inactive department.");
            }

            var data = Convert(department);
            return DataAccessLayer.DepartmentContent().Update(data);
        }
        public static int Delete(DepartmentDTO dept)
        {
            var data = Convert(dept);
            return DataAccessLayer.DepartmentContent().Delete(data);
        }

        static DepartmentDTO Convert(Department department)
        {
            return new DepartmentDTO()
            {
                Id = department.Id,
                isActive = department.isActive,
                Name = department.Name,
                UpdateBy = department.UpdateBy,
                UpdateTime = department.UpdateTime
            };
        }
        static Department Convert(DepartmentDTO department)
        {
            return new Department()
            {
                Id = department.Id,
                isActive = department.isActive,
                Name = department.Name,
                UpdateBy = department.UpdateBy,
                UpdateTime = department.UpdateTime
            };
        }
    }
}
