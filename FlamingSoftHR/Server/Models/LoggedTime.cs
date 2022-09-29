using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTime
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateLogged { get; set; }
        [Required]
        public float Hours { get; set; }
        [Required]
        public int LogType { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        [ForeignKey("LoggedTimeTypedId")]
        public int LoggedTimeTypeId { get; set; }
        public virtual Employee Employees { get; set; }
        
        public virtual LoggedTimeType LoggedTimeTypes { get; set; }
    }
}
