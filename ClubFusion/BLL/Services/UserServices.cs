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
    public class UserServices
    {
        public static List<UserDTO> GetAll()
        {
            var data = DataAccessLayer.UserContent().GetAll();
            return Convert(data);
        }
        public static UserDTO Get(int id)
        {
            var data = DataAccessLayer.UserContent().GetById(id);
            return Convert(data);
        }
        public static int Add(UserDTO user)
        {
            var data = Convert(user);
            return DataAccessLayer.UserContent().Insert(data);
        }
        public static int Edit(UserDTO user)
        {
            var data = Convert(user);
            return DataAccessLayer.UserContent().Update(data);
        }
        public static string Delete(UserDTO user)
        {
            var data = Convert(user);

            var ManagersWithUser = DataAccessLayer.ClubManagerContent().GetAll().Where(cm => cm.UserId == data.Id).ToList();

            if (ManagersWithUser.Any())
            {
                var failureMessage = "Failure due to reference";
                return failureMessage;
            }

            DataAccessLayer.UserContent().Delete(data);
            return "Data Deleted successfully";
        }

        static List<UserDTO> Convert(List<User> user)
        {
            var data = new List<UserDTO>();
            foreach(User x in user)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<User> Convert(List<UserDTO> user)
        {
            var data = new List<User>();
            foreach (UserDTO x in user)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static UserDTO Convert(User user)
        {
            return new UserDTO()
            {
                DateOfBirth = user.DateOfBirth,
                BloodGroup = user.BloodGroup,
                Email = user.Email,
                Id = user.Id,
                Image = user.Image,
                isActive = user.isActive,
                Name = user.Name,
                Password =user.Password,
                PhoneNo = user.PhoneNo,
                UpdateTime =user.UpdateTime,
                UserType =user.UserType,
                UpdateBy =user.UpdateBy
            };
        }
        static User Convert(UserDTO user)
        {
            return new User()
            {
                DateOfBirth = user.DateOfBirth,
                BloodGroup = user.BloodGroup,
                Email = user.Email,
                Id = user.Id,
                Image = user.Image,
                isActive = user.isActive,
                Name = user.Name,
                Password = user.Password,
                PhoneNo = user.PhoneNo,
                UpdateTime = user.UpdateTime,
                UserType = user.UserType,
                UpdateBy = user.UpdateBy
            };
        }
    }
}
