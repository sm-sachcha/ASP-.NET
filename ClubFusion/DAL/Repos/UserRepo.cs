using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class UserRepo : Repository, IRepository<User, int, int, User>
    {
        public int Delete(User obj)
        {
            var data = cfContext.Users.Find(obj.Id);
            cfContext.Users.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return cfContext.Users.ToList();
        }

        public User GetById(int id)
        {
            return cfContext.Users.Find(id);
        }

        public int Insert(User obj)
        {
            cfContext.Users.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(User obj)
        {
            var data = cfContext.Users.Find(obj.Id);
            data.Name = obj.Name;
            data.isActive = obj.isActive;
            data.PhoneNo = obj.PhoneNo;
            data.UpdateBy = obj.UpdateBy;
            data.UpdateTime = obj.UpdateTime;
            data.UserType = obj.UserType;
            return cfContext.SaveChanges();
        }
    }
}
