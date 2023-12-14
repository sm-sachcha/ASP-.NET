using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class DivisionRepo : Repository, IRepository<Division, int, int, Division>
    {
        public int Delete(Division obj)
        {
            var data = cfContext.Divisions.Find(obj.Id);
            cfContext.Divisions.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Division> GetAll()
        {
            return cfContext.Divisions.ToList();
        }

        public Division GetById(int id)
        {
            return cfContext.Divisions.Find(id);
        }

        public int Insert(Division obj)
        {
            cfContext.Divisions.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Division obj)
        {
            var data = cfContext.Divisions.Find(obj.Id);
            data.Id = obj.Id;
            data.isActive = obj.isActive;
            data.Name = obj.Name;
            data.UpdateBy = obj.UpdateBy;
            data.UpdateTime = obj.UpdateTime;
            return cfContext.SaveChanges();
        }
    }
}
