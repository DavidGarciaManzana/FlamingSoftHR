namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<LoggedTime> LoggedTimeModel { get; set; }
    }
}
