using EmployeeManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.Data
{
    public class EmployeeManagerDbContext : DbContext; 
    {
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

    }
}
