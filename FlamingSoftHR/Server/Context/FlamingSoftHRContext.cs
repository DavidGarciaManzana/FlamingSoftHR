using FlamingSoftHR.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server
{
    public class FlamingSoftHRContext : DbContext
    {
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<LoggedTime> LoggedTimes { get; set; }
        public DbSet<LoggedTimeType> LoggedTimeTypes { get; set; }
        public FlamingSoftHRContext(DbContextOptions<FlamingSoftHRContext> options):base(options){ }
    }
}
