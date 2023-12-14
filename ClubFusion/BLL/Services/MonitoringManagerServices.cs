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
    public class MonitoringManagerServices
    {
        public static List<MonitoringManagerDTO> GetAll()
        {
            var data = DataAccessLayer.MonitoringManagerContent().GetAll();
            return Convert(data);
        }
        public static MonitoringManagerDTO Get(int id)
        {
            var data = DataAccessLayer.MonitoringManagerContent().GetById(id);
            return Convert(data);
        }

        public static int Add(MonitoringManagerDTO obj)
        {
            var data = Convert(obj);
            return DataAccessLayer.MonitoringManagerContent().Insert(data);
        }
        public static int Edit(MonitoringManagerDTO obj)
        {
            var data = Convert(obj);
            return DataAccessLayer.MonitoringManagerContent().Update(data);
        }
        public static int Delete(MonitoringManagerDTO obj)
        {
            var data = Convert(obj);
            return DataAccessLayer.MonitoringManagerContent().Delete(data);
        }

        static List<MonitoringManagerDTO> Convert(List<MonitoringManager> monitoringManagers)
        {
            var data =new  List<MonitoringManagerDTO>();
            foreach(MonitoringManager x in monitoringManagers)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<MonitoringManager> Convert(List<MonitoringManagerDTO> monitoringManagers)
        {
            var data = new List<MonitoringManager>();
            foreach (MonitoringManagerDTO x in monitoringManagers)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static MonitoringManagerDTO Convert(MonitoringManager monitoring)
        {
            return new MonitoringManagerDTO()
            {
                Id = monitoring.Id,
                MonitoringManagerId = monitoring.MonitoringManagerId,
                PresentAddress = monitoring.PresentAddress,
                PermanentAddress = monitoring.PermanentAddress,
                PhoneNo = monitoring.PhoneNo,
                Email = monitoring.Email,
                JoiningDate = monitoring.JoiningDate,
                LeavingDate = monitoring.LeavingDate,
                DateOfBirth = monitoring.DateOfBirth,
                NidNo = monitoring.NidNo,
                FatherName = monitoring.FatherName,
                MotherName = monitoring.MotherName,
                Gender = monitoring.Gender,
                TaskId = monitoring.TaskId,
                UserId = monitoring.UserId
            };
        }
        static MonitoringManager Convert(MonitoringManagerDTO monitoring)
        {
            return new MonitoringManager()
            {
                Id = monitoring.Id,
                MonitoringManagerId = monitoring.MonitoringManagerId,
                PresentAddress = monitoring.PresentAddress,
                PermanentAddress = monitoring.PermanentAddress,
                PhoneNo = monitoring.PhoneNo,
                Email = monitoring.Email,
                JoiningDate = monitoring.JoiningDate,
                LeavingDate = monitoring.LeavingDate,
                DateOfBirth = monitoring.DateOfBirth,
                NidNo = monitoring.NidNo,
                FatherName = monitoring.FatherName,
                MotherName = monitoring.MotherName,
                Gender = monitoring.Gender,
                TaskId = monitoring.TaskId,
                UserId = monitoring.UserId
            };
        }
    }
}
