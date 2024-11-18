using EmployeeDotNet8.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDotNet8.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public  DbSet<Todolist> Todolist { get; set; }
        public DbSet<Emergency> emergencies {  get; set; } 
    }
}
