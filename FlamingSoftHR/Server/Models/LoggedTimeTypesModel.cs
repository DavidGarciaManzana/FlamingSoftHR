namespace FlamingSoftHR.Server.Models
{
    public class LoggedTimeTypesModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<LoggedTimeModel> LoggedTimeModel { get; set; }
    }
}
