using DAL.Entities;
using DAL.Interface;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessLayer
    {
        public static IRepository<Designation, int, int, Designation> DesignationContent()
        {
            return new DesignationRepo();
        }
        public static IRepository<Division, int, int, Division> DivisionContent()
        {
            return new DivisionRepo();
        }
        public static IRepository<Location, int, int, Location> LocationContent()
        {
            return new LocationRepos();
        }
        public static IRepository<Customer, int, int, Customer> CustomerContent()
        {
            return new CustomerRepo();
        }
        public static IDept<Department, int, int, Department> DepartmentContent()
        {
            return new DeptRepo();
        }
        public static IRepository<Employee, int, int, Employee> EmployeeContent()
        {
            return new EmployeeRepo();
        }
        public static IRepository<Order, int, int, Order> OrderContent()
        {
            return new OrderRepo();
        }
        public static IDept<ProductColor, int, int, ProductColor> ProductColorContent()
        {
            return new ProductColorRepo();
        }
        public static IDept<ProductGrade, int, int, ProductGrade> ProductGradeContent()
        {
            return new ProductGradeRepo();
        }
        public static IRepository<Club, int, int, Club> ClubContent()
        {
            return new ClubRepo();
        }
        public static IDept<ProductSize, int,int, ProductSize> ProductSizeContent()
        {
            return new ProductSizeRepo();
        }
        public static IRepository<Entities.Task, int, int, Entities.Task> TaskContent()
        {
            return new TaskRepo();
        }
        public static IRepository<ClubManager, int, int, ClubManager> ClubManagerContent()
        {
            return new ClubManagerRepo();
        }
        public static IRepository<UnitOfProduct, int, int, UnitOfProduct> UnitOfProductContent()
        {
            return new UnitOfProductRepo();
        }
        public static IRepository<User, int, int, User> UserContent()
        {
            return new UserRepo();
        }
        public static IRepository<MonitoringManager, int, int, MonitoringManager> MonitoringManagerContent()
        {
            return new MonitoringManagerRepo();
        }
        public static IAuthentication AuthData()
        {
            return new UserRepo();
        }
    }
}
