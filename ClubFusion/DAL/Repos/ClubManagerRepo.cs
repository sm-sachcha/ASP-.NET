using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class ClubManagerRepo : Repository, IRepository<ClubManager, int, int, ClubManager>
    {
        public int Delete(ClubManager obj)
        {
            var data = cfContext.ClubManagers.Find(obj.UserId);
            cfContext.ClubManagers.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<ClubManager> GetAll()
        {
            return cfContext.ClubManagers.ToList();
        }

        public ClubManager GetById(int id)
        {
            return cfContext.ClubManagers.Find(id);
        }

        public int Insert(ClubManager obj)
        {
            cfContext.ClubManagers.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(ClubManager obj)
        {
            var data = cfContext.ClubManagers.Find(obj.UserId);
            data.Name = obj.Name;
            data.ClubId = obj.ClubId;
            data.ClubManagerId = obj.ClubManagerId;
            return cfContext.SaveChanges();
        }
    }
}
