using System.ComponentModel.DataAnnotations;

namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeType
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public virtual ICollection<LoggedTime> LoggedTimes { get; set; }
    }
}
