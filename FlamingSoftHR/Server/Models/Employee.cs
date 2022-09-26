using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FlamingSoftHR.Server.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId")]

        public string UserId { get; set; }
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
        [JsonIgnore]
        public virtual Department Departments { get; set; }
        public virtual EmployeeType EmployeesTypes { get; set; }
        public virtual ICollection<LoggedTime> LoggedTimes { get; set; }
        public virtual AspNetUser AspNetUsers { get; set; }
    }
}
