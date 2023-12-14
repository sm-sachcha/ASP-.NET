using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class UnitOfProductRepo : Repository, IRepository<UnitOfProduct, int, int, UnitOfProduct>
    {
        public int Delete(UnitOfProduct obj)
        {
            var data = cfContext.UnitOfProducts.Find(obj.Id);
            cfContext.UnitOfProducts.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<UnitOfProduct> GetAll()
        {
            return cfContext.UnitOfProducts.ToList();
        }

        public UnitOfProduct GetById(int id)
        {
            return cfContext.UnitOfProducts.Find(id);
        }

        public int Insert(UnitOfProduct obj)
        {
            cfContext.UnitOfProducts.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(UnitOfProduct obj)
        {
            var data = cfContext.UnitOfProducts.Find(obj.Id);
            data.Name = obj.Name;
            data.Quantity = obj.Quantity;
            return cfContext.SaveChanges();
        }
    }
}
