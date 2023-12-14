using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class OrderRepo : Repository, IRepository<Order, int, int, Order>
    {
        public int Delete(Order obj)
        {
            var data = cfContext.Orders.Find(obj.OdrId);
            cfContext.Orders.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return cfContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return cfContext.Orders.Find(id);
        }

        public int Insert(Order obj)
        {
            cfContext.Orders.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Order obj)
        {
            var data = cfContext.Orders.Find(obj.OdrId);
            data.DeliveryDate = obj.DeliveryDate;
            return cfContext.SaveChanges();
        }
    }
}
