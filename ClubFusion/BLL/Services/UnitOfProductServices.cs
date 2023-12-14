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
    public class UnitOfProductServices
    {
        public static List<UnitOfProductDTO> GetAll()
        {
            var data = DataAccessLayer.UnitOfProductContent().GetAll();
            return Convert(data);
        }
        public static UnitOfProductDTO Get(int id)
        {
            var data = DataAccessLayer.UnitOfProductContent().GetById(id);
            return Convert(data);
        }

        public static int Add(UnitOfProductDTO unit)
        {
            var data = Convert(unit);
            return DataAccessLayer.UnitOfProductContent().Insert(data);
        }
        public static int Edit(UnitOfProductDTO unit)
        {
            var data = Convert(unit);
            return DataAccessLayer.UnitOfProductContent().Update(data);
        }
        public static int Delete(UnitOfProductDTO unit)
        {
            var data = Convert(unit);
            return DataAccessLayer.UnitOfProductContent().Delete(data);
        }

        static List<UnitOfProductDTO> Convert(List<UnitOfProduct> units)
        {
            var data = new List<UnitOfProductDTO>();
            foreach(UnitOfProduct x in units)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<UnitOfProduct> Convert(List<UnitOfProductDTO> units)
        {
            var data = new List<UnitOfProduct>();
            foreach (UnitOfProductDTO x in units)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static UnitOfProduct Convert(UnitOfProductDTO product)
        {
            return new UnitOfProduct
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
        static UnitOfProductDTO Convert(UnitOfProduct product)
        {
            return new UnitOfProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                UpdateBy = product.UpdateBy,
                UpdateTime = product.UpdateTime
            };
        }
    }
}
