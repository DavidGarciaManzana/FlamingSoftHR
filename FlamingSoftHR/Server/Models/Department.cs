using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Server.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Employee> EmployeesModels { get; set; }

    }
}
