using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CFContext : DbContext
    {
        // public static object Designation { get; internal set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubManager> ClubManagers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ProductGrade> ProductGrades { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<UnitOfProduct> UnitOfProducts { get; set; }
        public DbSet<MonitoringManager> MonitoringManagers { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}

