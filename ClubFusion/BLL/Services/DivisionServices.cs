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
    public class DivisionServices
    {
        public static List<DivisionDTO> GetAll()
        {
            var data = DataAccessLayer.DivisionContent().GetAll();
            return Convert(data);
        }
        public static DivisionDTO Get(int id)
        {
            var data = DataAccessLayer.DivisionContent().GetById(id);
            return Convert(data);
        }
        public static int Add(DivisionDTO dto)
        {
            var data = Convert(dto);
            return DataAccessLayer.DivisionContent().Insert(data);
        }
        public static int Delete(DivisionDTO dto)
        {
            var data = Convert(dto);
            return DataAccessLayer.DivisionContent().Delete(data);
        }
        public static int Edit(DivisionDTO dto)
        {
            var data = Convert(dto);
            return DataAccessLayer.DivisionContent().Update(data);
        }
        static List<Division> Convert(List<DivisionDTO> nwz)
        {
            var data = new List<Division>();
            foreach (DivisionDTO ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static Division Convert(DivisionDTO division)
        {
            return new Division()
            {
                Id = division.Id,
                Name = division.Name,
                isActive = division.isActive,
                UpdateTime = division.UpdateTime,
                UpdateBy = division.UpdateBy
            };
        }
        static List<DivisionDTO> Convert(List<Division> nwz)
        {
            var data = new List<DivisionDTO>();
            foreach (Division ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static DivisionDTO Convert(Division division)
        {
            return new DivisionDTO()
            {
                Id = division.Id,
                Name = division.Name,
                isActive = division.isActive,
                UpdateTime = division.UpdateTime,
                UpdateBy = division.UpdateBy
            };
        }
    }
}
