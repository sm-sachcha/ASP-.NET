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
    public class OrderServices
    {
        public static List<OrderDTO> GetAll()
        {
            var data = DataAccessLayer.OrderContent().GetAll();
            return Convert(data);
        }
        public static OrderDTO Get(int id)
        {
            var data = DataAccessLayer.OrderContent().GetById(id);
            return Convert(data);
        }
        public static int Add(OrderDTO odr)
        {
            var data = Convert(odr);
            return DataAccessLayer.OrderContent().Insert(data);
        }
        public static int Edit(OrderDTO odr)
        {
            var data = Convert(odr);
            return DataAccessLayer.OrderContent().Update(data);
        }
        public static int Delete(OrderDTO odr)
        {
            var data = Convert(odr);
            return DataAccessLayer.OrderContent().Delete(data);
        }

        static List<OrderDTO> Convert(List<Order> odr)
        {
            var data = new List<OrderDTO>();
            foreach(Order x in odr)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<Order> Convert(List<OrderDTO> odr)
        {
            var data = new List<Order>();
            foreach (OrderDTO x in odr)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static OrderDTO Convert(Order order)
        {
            return new OrderDTO()
            {
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate,
                CustomerId = order.CustomerId,
                OdrId = order.OdrId,
                UpdateBy = order.UpdateBy,
                UpdateTime = order.UpdateTime
            };
        }
        static Order Convert(OrderDTO order)
        {
            return new Order()
            {
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.OrderDate,
                CustomerId = order.CustomerId,
                OdrId = order.OdrId,
                UpdateBy = order.UpdateBy,
                UpdateTime = order.UpdateTime
            };
        }
    }
}
