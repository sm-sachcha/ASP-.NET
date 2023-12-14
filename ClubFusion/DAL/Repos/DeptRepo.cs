using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class DeptRepo : Repository, IDept<Department, int, int, Department>
    {
        public int Delete(Department obj)
        {
            var data = cfContext.Departments.Find(obj.Id);
            cfContext.Departments.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Department> GetAll()
        {
            return cfContext.Departments.ToList();
        }

        public int Insert(Department obj)
        {
            cfContext.Departments.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Department obj)
        {
            var data = cfContext.Departments.Find(obj.Id);
            data.Id = obj.Id;
            data.isActive = obj.isActive;
            data.UpdateTime = obj.UpdateTime;
            data.Name = obj.Name;
            data.isActive = obj.isActive;
            return cfContext.SaveChanges();
        }
    }
}
