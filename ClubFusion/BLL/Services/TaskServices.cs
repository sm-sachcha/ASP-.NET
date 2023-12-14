using BLL.DTOs;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BLL.Services
{
    public class TaskServices
    {
        public static List<TaskDTO> GetAll()
        {
            var data = DataAccessLayer.TaskContent().GetAll();
            return Convert(data);
        }
        public static TaskDTO Get(int id)
        {
            var data = DataAccessLayer.TaskContent().GetById(id);
            return Convert(data);
        }
        public static int Add(TaskDTO task)
        {
            var data = Convert(task);
            return DataAccessLayer.TaskContent().Insert(data);
        }
        public static int Edit(TaskDTO task)
        {
            var data = Convert(task);
            return DataAccessLayer.TaskContent().Update(data);
        }
        public static int Delete(TaskDTO task)
        {
            var data = Convert(task);
            return DataAccessLayer.TaskContent().Delete(data);
        }

        static List<TaskDTO> Convert(List<Task> task)
        {
            var data = new List<TaskDTO>();
            foreach(Task x in task)
            {
                data.Add(Convert(x));
            }
            return data;
        }
        static List<Task> Convert(List<TaskDTO> task)
        {
            var data = new List<Task>();
            foreach (TaskDTO x in task)
            {
                data.Add(Convert(x));
            }
            return data;
        }

        static Task Convert(TaskDTO task)
        {
            return new Task()
            {
                EntryDate = task.EntryDate,
                FinishDate = task.FinishDate,
                Id = task.Id,
                Image = task.Image,
                IsActive = task.IsActive,
                LocationId = task.LocationId,
                UpdateBy = task.UpdateBy,
                UpdateTime = task.UpdateTime,
                Name = task.Name
            };
        }
        static TaskDTO Convert(Task task)
        {
            return new TaskDTO()
            {
                EntryDate = task.EntryDate,
                FinishDate = task.FinishDate,
                Id = task.Id,
                Image = task.Image,
                IsActive = task.IsActive,
                LocationId = task.LocationId,
                UpdateBy = task.UpdateBy,
                UpdateTime = task.UpdateTime,
                Name = task.Name
            };
        }
    }
}
