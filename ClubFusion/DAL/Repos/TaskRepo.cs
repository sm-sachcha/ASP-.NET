using DAL.Entities;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repos
{
    class TaskRepo : Repository, IRepository<Task, int, int, Task>
    {
        public int Delete(Task obj)
        {
            var data = cfContext.Tasks.Find(obj.Id);
            cfContext.Tasks.Remove(data);
            return cfContext.SaveChanges();
        }

        public List<Task> GetAll()
        {
            return cfContext.Tasks.ToList();
        }

        public Task GetById(int id)
        {
            return cfContext.Tasks.Find(id);
        }

        public int Insert(Task obj)
        {
            cfContext.Tasks.Add(obj);
            return cfContext.SaveChanges();
        }

        public int Update(Task obj)
        {
            var data = cfContext.Tasks.Find(obj.Id);
            data.Name = obj.Name;
            data.FinishDate = obj.FinishDate;
            data.IsActive = obj.IsActive;
            data.Location = obj.Location;
            data.UpdateBy = obj.UpdateBy;
            return cfContext.SaveChanges();
        }
    }
}
