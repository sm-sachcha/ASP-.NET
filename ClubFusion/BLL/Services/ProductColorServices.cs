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
    public class ProductColorServices
    {
     public static List<ProductColorDTO> GetAll()
        {
            var data = DataAccessLayer.ProductColorContent().GetAll();
            return Convert(data);
        }

        static List<ProductColorDTO> Convert(List<ProductColor> colors)
        {
            var data = new List<ProductColorDTO>();
            foreach(ProductColor x in colors)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        public static int Add(ProductColorDTO productColor)
        {
            var data = Convert(productColor);
            return DataAccessLayer.ProductColorContent().Insert(data);
        }
        public static int Edit(ProductColorDTO productColor)
        {
            var data = Convert(productColor);
            return DataAccessLayer.ProductColorContent().Update(data);
        }
        public static int Delete(ProductColorDTO productColor)
        {
            var data = Convert(productColor);
            return DataAccessLayer.ProductColorContent().Delete(data);
        }

        static ProductColor Convert(ProductColorDTO product)
        {
            return new ProductColor()
            {
                Id = product.Id,
                isActive = product.isActive,
                Name = product.Name,
                ProductColorCode = product.ProductColorCode,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
        static ProductColorDTO Convert(ProductColor product)
        {
            return new ProductColorDTO()
            {
                Id = product.Id,
                isActive = product.isActive,
                Name = product.Name,
                ProductColorCode = product.ProductColorCode,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
    }
}
