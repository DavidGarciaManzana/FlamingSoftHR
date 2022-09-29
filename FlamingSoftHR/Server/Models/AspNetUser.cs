
namespace FlamingSoftHR.Server.Models
{
    public class AspNetUser
    {
        public string Id { get; set; }
        public string? UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public Boolean EmailConfirmed { get; set; }
        public string? PasswordHash { get; set; }
        public string? SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; }
        public string? PhoneNumber { get; set; }
        public Boolean PhoneNumberConfirmed { get; set; }
        public Boolean TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public Boolean LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }

    }
}
