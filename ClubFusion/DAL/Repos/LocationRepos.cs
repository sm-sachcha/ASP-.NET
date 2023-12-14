using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class LocationRepos : Repository, IRepository<Location, int, int, Location>
    {
        public int Delete(Location obj)
        {
            var data = cfContext.Locations.Find(obj.Id);
            cfContext.Locations.Remove(obj);
            return cfContext.SaveChanges();
        }

        public List<Location> GetAll()
        {
            return cfContext.Locations.ToList();
        }

        public Location GetById(int id)
        {
            return cfContext.Locations.Find(id);
        }

        public int Insert(Location obj)
        {
            cfContext.Locations.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Location obj)
        {
            var data = cfContext.Locations.Find(obj.Id);
            data.Name = obj.Name;
            data.isActive = obj.isActive;
            data.UpdateBy = obj.UpdateBy;
            return cfContext.SaveChanges();
        }
    }
}
