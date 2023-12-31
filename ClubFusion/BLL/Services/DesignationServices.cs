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
    public class DesignationServices
    {
        public static List<DesignationDTO> GetAll()
        {
            var data = DataAccessLayer.DesignationContent().GetAll();
            return Convert(data);
        }
        public static DesignationDTO Get(int id)
        {
            var data = DataAccessLayer.DesignationContent().GetById(id);
            return Convert(data);
        }
        public static int Add(DesignationDTO dto)
        {
            var existingClub = DataAccessLayer.DesignationContent().GetAll().FirstOrDefault(c => c.Name.Equals(dto.Name, StringComparison.OrdinalIgnoreCase));

            if (existingClub != null)
            {
                throw new InvalidOperationException("Designation with the same name already exists");
            }
            var data = Convert(dto);
            return DataAccessLayer.DesignationContent().Insert(data);
        }
        public static int Delete(DesignationDTO dto)
        {
            var data = Convert(dto);
            return DataAccessLayer.DesignationContent().Delete(data);
        }
        public static int Edit(DesignationDTO dto)
        {
            var existingData = DataAccessLayer.DesignationContent().GetById(dto.Id);

            if (existingData.IsActive && !dto.IsActive)
            {
                throw new InvalidOperationException("Cannot edit Inactive Designation.");
            }

            var data = Convert(dto);
            return DataAccessLayer.DesignationContent().Update(data);
        }


        static List<Designation> Convert(List<DesignationDTO> nwz)
        {
            var data = new List<Designation>();
            foreach (DesignationDTO ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static Designation Convert(DesignationDTO designation)
        {
            return new Designation()
            {
                Id = designation.Id,
                Name = designation.Name,
                IsActive = designation.IsActive,
                UpdateTime = designation.UpdateTime,
                UpdateBy = designation.UpdateBy
            };
        }
        static List<DesignationDTO> Convert(List<Designation> designations)
        {
            var data = new List<DesignationDTO>();
            foreach (Designation x in designations)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static DesignationDTO Convert(Designation designation)
        {
            return new DesignationDTO()
            {
                Id = designation.Id,
                Name = designation.Name,
                IsActive = designation.IsActive,
                UpdateTime = designation.UpdateTime,
                UpdateBy = designation.UpdateBy
            };
        }
    }
}
