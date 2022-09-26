using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
