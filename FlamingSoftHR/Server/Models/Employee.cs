using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Server.Models
{
    public class Employee
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

        public virtual Department DepartmentsModel { get; set; }
        public virtual EmployeeType EmployeesTypesModel { get; set; }
        public virtual ICollection<LoggedTime> LoggedTimeModel { get; set; }
    }
}
