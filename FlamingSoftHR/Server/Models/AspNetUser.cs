using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Server.Models
{
    public class AspNetUser
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(256)]
        public string UserName { get; set; }
        [MaxLength(256)]
        public string NormalizedUserName { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(256)]
        public string NormalizedEmail { get; set; }
        [Required]
        public int EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string PhoneNumberConfirmed { get; set; }
        [Required]
        public int TwoFactorEnabled { get; set; }
        public DateTime LockoutEnd { get; set; }
        [Required]
        public int LockoutEnabled { get; set; }
        [Required]
        public int AccessFailedCount { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }


    }
}
