using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class CustomerRepo : Repository, IRepository<Customer, int, int, Customer>
    {
        public int Delete(Customer obj)
        {
            var data = cfContext.Customers.Find(obj.Id);
            cfContext.Customers.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return cfContext.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return cfContext.Customers.Find(id);
        }

        public int Insert(Customer obj)
        {
            cfContext.Customers.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Customer obj)
        {
            var data = cfContext.Customers.Find(obj.Id);
            data.Address = obj.Address;
            data.ClubId = obj.ClubId;
            data.Email = obj.Email;
            data.Id = obj.Id;
            data.Name = obj.Name;
            data.PhoneNo = obj.PhoneNo;
            data.isActive = obj.isActive;
            return cfContext.SaveChanges();
        }
    }
}
