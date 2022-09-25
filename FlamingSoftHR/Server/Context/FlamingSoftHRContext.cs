using FlamingSoftHR.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server
{
    public class FlamingSoftHRContext : DbContext
    {
        public DbSet<DepartmentsModel> DepartmentsModels { get; set; }
        public DbSet<EmployeesModel> EmployeesModels { get; set; }
        public DbSet<EmployeesTypesModel> EmployeesTypesModels { get; set; }
        public DbSet<LoggedTimeModel> LoggedTimeModels { get; set; }
        public DbSet<LoggedTimeTypesModel> LoggedTimeTypesModels { get; set; }
        public FlamingSoftHRContext(DbContextOptions<FlamingSoftHRContext> options):base(options){ }
    }
}
