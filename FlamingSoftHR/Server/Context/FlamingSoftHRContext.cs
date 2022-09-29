using FlamingSoftHR.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace FlamingSoftHR.Server
{
    public class FlamingSoftHRContext : DbContext
    {
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<LoggedTime> LoggedTime { get; set; }
        public DbSet<LoggedTimeType> LoggedTimeTypes { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public DbSet<PersistedGrant> PersistedGrants { get; set; }
        public DbSet<DeviceCodes> DeviceCodes { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<EFMigrationsHistory> __EFMigrationsHistory { get; set; }
        
        public FlamingSoftHRContext(DbContextOptions<FlamingSoftHRContext> options):base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUser>(aspNetUser =>
            {
                aspNetUser.ToTable("AspNetUsers");
                aspNetUser.HasKey(p => p.Id);
                aspNetUser.Property(p => p.UserName).HasMaxLength(256);
                aspNetUser.Property(p => p.NormalizedUserName).HasMaxLength(256);
                aspNetUser.Property(p => p.Email).HasMaxLength(256);
                aspNetUser.Property(p => p.NormalizedEmail).HasMaxLength(256);
                aspNetUser.Property(p => p.EmailConfirmed).IsRequired();
                aspNetUser.Property(p => p.PasswordHash);
                aspNetUser.Property(p => p.SecurityStamp);
                aspNetUser.Property(p => p.ConcurrencyStamp);
                aspNetUser.Property(p => p.PhoneNumber);
                aspNetUser.Property(p => p.PhoneNumberConfirmed).IsRequired();
                aspNetUser.Property(p => p.TwoFactorEnabled).IsRequired();
                aspNetUser.Property(p => p.LockoutEnd);
                aspNetUser.Property(p => p.LockoutEnabled).IsRequired();
                aspNetUser.Property(p => p.AccessFailedCount).IsRequired();


            });
            modelBuilder.Entity<Employee>(employee =>
            {
                employee.ToTable("Employees");
                employee.HasKey(p => p.Id);
                employee.HasOne(p => p.AspNetUsers).WithMany(p => p.Employees).HasForeignKey(p => p.UserId);
                employee.Property(p => p.FirstName).IsRequired();
                employee.Property(p => p.MiddleName);
                employee.Property(p => p.LastName).IsRequired();
                employee.HasOne(p => p.Departments).WithMany(p => p.Employees).HasForeignKey(p => p.DepartmentId);
                employee.HasOne(p => p.EmployeesTypes).WithMany(p => p.Employees).HasForeignKey(p => p.EmployeeTypeId);
            });
            modelBuilder.Entity<AspNetUserLogin>(aspNetUserLogin =>
            {
                aspNetUserLogin.ToTable("AspNetUserLogins");
                aspNetUserLogin.HasKey(p => new { p.LoginProvider, p.ProviderKey });
                aspNetUserLogin.Property(p => p.ProviderDisplayName);
                aspNetUserLogin.HasOne(p => p.AspNetUsers).WithMany(p => p.AspNetUserLogins).HasForeignKey(p=> p.UserId);
            });
            modelBuilder.Entity<AspNetUserClaim>(aspNetUserClaim =>
            {
                aspNetUserClaim.ToTable("AspNetUserClaims");
                aspNetUserClaim.HasKey(p => p.Id);
                aspNetUserClaim.HasOne(p => p.AspNetUsers).WithMany(p => p.AspNetUserClaims).HasForeignKey(p => p.UserId);
                aspNetUserClaim.Property(p => p.ClaimType);
                aspNetUserClaim.Property(p => p.ClaimValue);
            });
            modelBuilder.Entity<AspNetUserToken>(aspNetUserToken =>
            {
                aspNetUserToken.ToTable("AspNetUserTokens");
                aspNetUserToken.HasKey(p => new { p.UserId, p.LoginProvider, p.Name });
                aspNetUserToken.HasOne(p => p.AspNetUsers).WithMany(p => p.AspNetUserTokens).HasForeignKey(p => p.UserId);
                aspNetUserToken.Property(p => p.Value);
        
            });
            modelBuilder.Entity<AspNetUserRole>(aspNetUserRole =>
            {
                aspNetUserRole.ToTable("AspNetUserRoles");
                aspNetUserRole.HasKey(p => new { p.UserId, p.RoleId});
                aspNetUserRole.HasOne(p => p.AspNetUsers).WithMany(p => p.AspNetUserRoles).HasPrincipalKey(p => p.Id);
                aspNetUserRole.HasOne(p => p.AspNetUsers).WithMany(p => p.AspNetUserRoles).HasForeignKey(p => p.RoleId);
            });
        }
    }

    
}
