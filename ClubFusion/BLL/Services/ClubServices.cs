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
    public class ClubServices
    {
        public static List<ClubDTO> GetAll()
        {
            var data = DataAccessLayer.ClubContent().GetAll();
            return Convert(data);
        }

        public static ClubDTO Get(int id)
        {
            var data = DataAccessLayer.ClubContent().GetById(id);
            return Convert(data);
        }
        public static int Add(ClubDTO club)
        {
            var existingClub = DataAccessLayer.ClubContent().GetAll().FirstOrDefault(c => c.Name.Equals(club.Name, StringComparison.OrdinalIgnoreCase));

            if (existingClub != null)
            {
                throw new InvalidOperationException("Club with the same name already exists");
            }

            var data = Convert(club);
            return DataAccessLayer.ClubContent().Insert(data);
        }

        public static int Delete(ClubDTO club)
        {
            var data = Convert(club);
            return DataAccessLayer.ClubContent().Delete(data);
        }


        public static int Edit(ClubDTO club)
        {
            var existingClub = DataAccessLayer.ClubContent().GetById(club.Id);

            if (existingClub == null)
            {
                throw new InvalidOperationException("Club not found for editing");
            }

            if (club.UpdateBy == 0 || club.UpdateBy == null)
            {
                var data = Convert(club);
                return DataAccessLayer.ClubContent().Update(data);
            }
            if (!existingClub.isActive)
            {
                throw new InvalidOperationException("Inactive Club can't be edited");
            }
            else
            {
                throw new InvalidOperationException("Only Admin can edit the Club");
            }
        }

        static List<ClubDTO> Convert(List<Club> club)
        {
            var data = new List<ClubDTO>();
            foreach(Club x in club)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<Club> Convert(List<ClubDTO> club)
        {
            var data = new List<Club>();
            foreach (ClubDTO x in club)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static Club Convert(ClubDTO club)
        {
            return new Club()
            {
                Id = club.Id,
                Name = club.Name,
                isActive = club.isActive,
                UpdateBy = club.UpdateBy,
                UpdateTime = club.UpdateTime,
                JoiningDate = club.JoiningDate,
                Image = club.Image
            };
        }
        static ClubDTO Convert(Club club)
        {
            return new ClubDTO()
            {
                Id = club.Id,
                Name = club.Name,
                isActive = club.isActive,
                UpdateBy = club.UpdateBy,
                UpdateTime = club.UpdateTime,
                JoiningDate = club.JoiningDate,
                Image = club.Image
            };
        }
    }
}
