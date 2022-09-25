using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeesModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(25)]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        [ForeignKey("EmployeeTypeId")]
        public int EmployeeTypeId { get; set; }

        public virtual DepartmentsModel DepartmentsModel { get; set; }
        public virtual EmployeesTypesModel EmployeesTypesModel { get; set; }
        public virtual ICollection<LoggedTimeModel> LoggedTimeModel { get; set; }
    }
}
