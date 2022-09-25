using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Server.Models
{
    public class DepartmentsModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual ICollection<EmployeesModel> EmployeesModels { get; set; }

    }
}
