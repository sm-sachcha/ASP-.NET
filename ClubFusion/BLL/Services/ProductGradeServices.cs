using BLL.DTOs;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ProductGradeServices
    {
        public static List<ProductGradeDTO>GetAll()
        {
            var data = DataAccessLayer.ProductGradeContent().GetAll();
            return Convert(data);
        }

        public static int Add(ProductGradeDTO product)
        {
            var data = Convert(product);
            return DataAccessLayer.ProductGradeContent().Insert(data);
        }
        public static int Edit(ProductGradeDTO product)
        {
            var data = Convert(product);
            return DataAccessLayer.ProductGradeContent().Update(data);
        }
        public static int Delete(ProductGradeDTO product)
        {
            var data = Convert(product);
            return DataAccessLayer.ProductGradeContent().Delete(data);
        }

        static List<ProductGradeDTO> Convert(List<ProductGrade> products)
        {
            var data = new List<ProductGradeDTO>();
            foreach(ProductGrade x in products)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<ProductGrade> Convert(List<ProductGradeDTO> products)
        {
            var data = new List<ProductGrade>();
            foreach (ProductGradeDTO x in products)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static ProductGrade Convert(ProductGradeDTO product)
        {
            return new ProductGrade
            {
                isActive = product.isActive,
                Id = product.Id,
                Name = product.Name,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
        static ProductGradeDTO Convert(ProductGrade product)
        {
            return new ProductGradeDTO
            {
                isActive = product.isActive,
                Id = product.Id,
                Name = product.Name,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
    }
}
