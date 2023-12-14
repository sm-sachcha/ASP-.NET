using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class ProductSizeRepo : Repository, IDept<ProductSize, int, int, ProductSize>
    {
        public int Delete(ProductSize obj)
        {
            var data = cfContext.ProductSizes.Find(obj.Id);
            cfContext.ProductSizes.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<ProductSize> GetAll()
        {
            return cfContext.ProductSizes.ToList();
        }

        public int Insert(ProductSize obj)
        {
            var data = cfContext.ProductSizes.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(ProductSize obj)
        {
            var data = cfContext.ProductSizes.Find(obj.Id);
            data.Id = obj.Id;
            data.isActive = obj.isActive;
            data.Name = obj.Name;
            data.ProductMeasurement = obj.ProductMeasurement;
            data.UpdateBy = obj.UpdateBy;
            data.UpdateTime = obj.UpdateTime;
            return cfContext.SaveChanges();
        }
    }
}
