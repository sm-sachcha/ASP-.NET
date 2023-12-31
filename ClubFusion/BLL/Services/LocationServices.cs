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
    public class LocationServices
    {
        public static List<LocationDTO> GetAll()
        {
            var data = DataAccessLayer.LocationContent().GetAll();
            return Convert(data);
        }

        public static LocationDTO Get(int id)
        {
            var data = DataAccessLayer.LocationContent().GetById(id);
            return Convert(data);
        }
        public static int Add(LocationDTO loc)
        {
            var existingClub = DataAccessLayer.LocationContent().GetAll().FirstOrDefault(c => c.Name.Equals(loc.Name, StringComparison.OrdinalIgnoreCase));

            if (existingClub != null)
            {
                throw new InvalidOperationException("Location with the same name already exists");
            }

            var data = Convert(loc);
            return DataAccessLayer.LocationContent().Insert(data);
        }

        public static int Delete(LocationDTO Location)
        {
            var data = Convert(Location);
            return DataAccessLayer.LocationContent().Delete(data);
        }
        public static int Edit(LocationDTO loc)
        {
            var existingClub = DataAccessLayer.LocationContent().GetById(loc.Id);

            if (existingClub == null)
            {
                throw new InvalidOperationException("Location not found for editing");
            }

            if (loc.UpdateBy == 0 || loc.UpdateBy == null)
            {
                var data = Convert(loc);
                return DataAccessLayer.LocationContent().Update(data);
            }
            if (!existingClub.isActive)
            {
                throw new InvalidOperationException("Only Admin can edit InActive location");
            }
            else
            {
                throw new InvalidOperationException("Invalid operation");
            }
        }

        static List<LocationDTO> Convert(List<Location> club)
        {
            var data = new List<LocationDTO>();
            foreach (Location x in club)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static List<Location> Convert(List<LocationDTO> club)
        {
            var data = new List<Location>();
            foreach (LocationDTO x in club)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static Location Convert(LocationDTO loc)
        {
            return new Location()
            {
                Id = loc.Id,
                isActive = loc.isActive,
                Name = loc.Name,
                UpdateBy = loc.UpdateBy
            };
        }
        static LocationDTO Convert(Location loc)
        {
            return new LocationDTO()
            {
                Id = loc.Id,
                isActive = loc.isActive,
                Name = loc.Name,
                UpdateBy = loc.UpdateBy
            };
        }
    }
}
