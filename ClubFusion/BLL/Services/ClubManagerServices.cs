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
    public class ClubManagerServices
    {
        public static List<ClubManagerDTO> GetALL()
        {
            var data = DataAccessLayer.ClubManagerContent().GetAll();
            return Convert(data);
        }
        public static ClubManagerDTO Get(int id)
        {
            var data = DataAccessLayer.ClubManagerContent().GetById(id);
            return Convert(data);
        }
        public static int Add(ClubManagerDTO mngr)
        {
            var data = Convert(mngr);
            return DataAccessLayer.ClubManagerContent().Insert(data);
        }

        public static int Delete(ClubManagerDTO mngr)
        {
            var data = Convert(mngr);
            return DataAccessLayer.ClubManagerContent().Delete(data);
        }
        public static int Edit(ClubManagerDTO mngr)
        {
            var data = Convert(mngr);
            return DataAccessLayer.ClubManagerContent().Update(data);
        }

        static List<ClubManagerDTO> Convert(List<ClubManager> managers)
        {
            var data = new List<ClubManagerDTO>();
            foreach(ClubManager x in managers)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<ClubManager> Convert(List<ClubManagerDTO> managers)
        {
            var data = new List<ClubManager>();
            foreach (ClubManagerDTO x in managers)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static ClubManagerDTO Convert(ClubManager clubmngr)
        {
            return new ClubManagerDTO()
            {
                Name = clubmngr.Name,
                ClubId = clubmngr.ClubId,
                ClubManagerId = clubmngr.ClubManagerId,
                UserId = clubmngr.UserId
            };
        }

        static ClubManager Convert(ClubManagerDTO clubmngr)
        {
            return new ClubManager()
            {
                Name = clubmngr.Name,
                ClubId = clubmngr.ClubId,
                ClubManagerId = clubmngr.ClubManagerId,
                UserId = clubmngr.UserId
            };
        }
    }
}
