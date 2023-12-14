using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DesignationRepo : Repository, IRepository<Designation, int, int, Designation>
    {
        public int Delete(Designation designation)
        {
            var data = cfContext.Designations.Find(designation.Id);
            cfContext.Designations.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Designation> GetAll()
        {
            return cfContext.Designations.ToList();
        }

        public Designation GetById(int id)
        {
            return cfContext.Designations.Find(id);
        }

        public int Insert(Designation desig)
        {
            cfContext.Designations.Add(desig);
            return cfContext.SaveChanges();
        }

        public int Update(Designation obj)
        {
            var data = cfContext.Designations.Find(obj.Id);
            data.Name = obj.Name;
            data.UpdateBy = obj.UpdateBy;
            data.UpdateTime = obj.UpdateTime;
            data.IsActive = obj.IsActive;
            return cfContext.SaveChanges();
        }
    }
}
