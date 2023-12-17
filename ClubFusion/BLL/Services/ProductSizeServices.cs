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
    public class ProductSizeServices
    {
        public static List<ProductSizeDTO> GetAll()
        {
            var data = DataAccessLayer.ProductSizeContent().GetAll();
            return Convert(data);
        }
        public static int Add(ProductSizeDTO sizeDTO)
        {
            var data = Convert(sizeDTO);
            return DataAccessLayer.ProductSizeContent().Insert(data);
        }
        public static int Edit(ProductSizeDTO sizeDTO)
        {
            var data = Convert(sizeDTO);
            return DataAccessLayer.ProductSizeContent().Update(data);
        }
        public static int Delete(ProductSizeDTO sizeDTO)
        {
            var data = Convert(sizeDTO);
            return DataAccessLayer.ProductSizeContent().Delete(data);
        }

        static List<ProductSizeDTO> Convert(List<ProductSize> data)
        {
            var list = new List<ProductSizeDTO>();
            foreach(ProductSize x in data)
            {
                list.Add(Convert(x));
            }
            return list;
        }
        static List<ProductSize> Convert(List<ProductSizeDTO> data)
        {
            var list = new List<ProductSize>();
            foreach (ProductSizeDTO x in data)
            {
                list.Add(Convert(x));
            }
            return list;
        }

        static ProductSizeDTO Convert(ProductSize product)
        {
            return new ProductSizeDTO
            {
                Id = product.Id,
                isActive = product.isActive,
                Name = product.Name,
                ProductMeasurement = product.ProductMeasurement,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
        static ProductSize Convert(ProductSizeDTO product)
        {
            return new ProductSize
            {
                Id = product.Id,
                isActive = product.isActive,
                Name = product.Name,
                ProductMeasurement = product.ProductMeasurement,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
    }
}
