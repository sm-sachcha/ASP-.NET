using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class ProductColorRepo : Repository, IDept<ProductColor, int, int, ProductColor>
    {
        public int Delete(ProductColor obj)
        {
            var data = cfContext.ProductColors.Find(obj.Id);
            cfContext.ProductColors.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<ProductColor> GetAll()
        {
            return cfContext.ProductColors.ToList();
        }

        public int Insert(ProductColor obj)
        {
            var data = cfContext.ProductColors.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(ProductColor obj)
        {
            var data = cfContext.ProductColors.Find(obj.Id);
            data.Id = obj.Id;
            data.isActive = obj.isActive;
            data.Name = obj.Name;
            data.ProductColorCode = obj.ProductColorCode;
            return cfContext.SaveChanges();
        }
    }
}
