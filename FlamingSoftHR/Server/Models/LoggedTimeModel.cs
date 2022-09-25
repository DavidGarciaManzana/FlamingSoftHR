using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateLogged { get; set; }
        [Required]
        public float Hours { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("LoggedTimeTypedId")]
        public int LoggedTimeTypedId { get; set; }
        public virtual EmployeesModel EmployeesModel { get; set; }
        public virtual LoggedTimeTypesModel LoggedTimeTypesModel { get; set; }
    }
}
