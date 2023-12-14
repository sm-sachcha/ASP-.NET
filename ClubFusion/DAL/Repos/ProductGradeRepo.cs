using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class ProductGradeRepo : Repository, IDept<ProductGrade, int, int, ProductGrade>
    {
        public int Delete(ProductGrade obj)
        {
            var data = cfContext.ProductGrades.Find(obj.Id);
            cfContext.ProductGrades.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<ProductGrade> GetAll()
        {
            return cfContext.ProductGrades.ToList();
        }

        public int Insert(ProductGrade obj)
        {
            cfContext.ProductGrades.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(ProductGrade obj)
        {
            var data = cfContext.ProductGrades.Find(obj.Id);
            data.isActive = obj.isActive;
            data.Name = obj.Name;
            data.UpdateBy = obj.UpdateBy;
            data.UpdateTime = obj.UpdateTime;
            return cfContext.SaveChanges();
        }
    }
}
