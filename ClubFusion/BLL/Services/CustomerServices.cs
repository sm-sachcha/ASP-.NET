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
    public class CustomerServices
    {
        public static List<CustomerDTO> GetAll()
        {
            var data = DataAccessLayer.CustomerContent().GetAll();
            return Convert(data);
        }

        public static CustomerDTO Get(int id)
        {
            var data = DataAccessLayer.CustomerContent().GetById(id);
            return Convert(data);
        }
        public static int Add(CustomerDTO cst)
        {
            var data = Convert(cst);
            return DataAccessLayer.CustomerContent().Insert(data);
        }
        public static int Edit(CustomerDTO customer)
        {
            if (!customer.isActive)
            {
                throw new InvalidOperationException("Inactive customers cannot be edited.");
            }

            var data = Convert(customer);
            return DataAccessLayer.CustomerContent().Update(data);
        }
        public static int Delete(CustomerDTO customer)
        {
            var data = Convert(customer);
            return DataAccessLayer.CustomerContent().Delete(data);
        }

        static List<CustomerDTO> Convert(List<Customer> customers)
        {
            var data = new List<CustomerDTO>();
            foreach(Customer x in customers)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static List<Customer> Convert(List<CustomerDTO> customers)
        {
            var data = new List<Customer>();
            foreach (CustomerDTO x in customers)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static Customer Convert(CustomerDTO customer)
        {
            return new Customer()
            {
                Address = customer.Address,
                Email = customer.Email,
                Id = customer.Id,
                isActive = customer.isActive,
                Name = customer.Name,
                PhoneNo = customer.PhoneNo,
                ClubId =customer.ClubId
            };
        }
        static CustomerDTO Convert(Customer customer)
        {
            return new CustomerDTO()
            {
                Address = customer.Address,
                Email = customer.Email,
                Id = customer.Id,
                isActive = customer.isActive,
                Name = customer.Name,
                PhoneNo = customer.PhoneNo,
                ClubId = customer.ClubId
            };
        }
    }
}
