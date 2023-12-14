using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class MonitoringManagerRepo : Repository, IRepository<MonitoringManager, int, int, MonitoringManager>
    {
        public int Delete(MonitoringManager obj)
        {
            var data = cfContext.MonitoringManagers.Find(obj.MonitoringManagerId);
            cfContext.MonitoringManagers.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<MonitoringManager> GetAll()
        {
            return cfContext.MonitoringManagers.ToList();
        }

        public MonitoringManager GetById(int id)
        {
            return cfContext.MonitoringManagers.Find(id);
        }

        public int Insert(MonitoringManager obj)
        {
            var data = cfContext.MonitoringManagers.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(MonitoringManager obj)
        {
            var data = cfContext.MonitoringManagers.Find(obj.MonitoringManagerId);
            data.JoiningDate = obj.JoiningDate;
            data.MonitoringManagerId = obj.MonitoringManagerId;
            data.Name = obj.Name;
            data.MotherName = obj.MotherName;
            data.FatherName = obj.FatherName;
            data.DateOfBirth = obj.DateOfBirth;
            data.Email = obj.Email;
            data.PermanentAddress = obj.PermanentAddress;
            data.PresentAddress = obj.PresentAddress;
            data.NidNo = obj.NidNo;
            data.TaskId = obj.TaskId;
            data.UserId = obj.UserId;
            return cfContext.SaveChanges();
        }
    }
}
