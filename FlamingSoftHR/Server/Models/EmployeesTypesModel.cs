using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeesTypesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        public virtual ICollection<EmployeesModel> EmployeesModels { get; set; }
    }
}
