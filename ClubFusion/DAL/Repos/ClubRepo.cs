using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class ClubRepo : Repository, IRepository<Club, int, int, Club>
    {
        public int Delete(Club obj)
        {
            var data = cfContext.Clubs.Find(obj.Id);
            cfContext.Clubs.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Club> GetAll()
        {
            return cfContext.Clubs.ToList();
        }

        public Club GetById(int id)
        {
            return cfContext.Clubs.Find(id);
        }

        public int Insert(Club obj)
        {
            var data = cfContext.Clubs.Find(obj.Id);
            cfContext.Clubs.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Club obj)
        {
            var data = cfContext.Clubs.Find(obj.Id);
            data.Image = obj.Image;
            data.isActive = obj.isActive;
            data.JoiningDate = obj.JoiningDate;
            data.Name = obj.Name;
            data.UpdateBy = obj.UpdateBy;
            data.UpdateTime = obj.UpdateTime;
            return cfContext.SaveChanges();
        }
    }
}
