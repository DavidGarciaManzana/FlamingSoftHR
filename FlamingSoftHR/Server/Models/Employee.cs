

namespace FlamingSoftHR.Server.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public int EmployeeTypeId { get; set; }
        public virtual Department Departments { get; set; }
        public virtual EmployeeType EmployeesTypes { get; set; }
        public virtual ICollection<LoggedTime> LoggedTimes { get; set; }
        public virtual AspNetUser AspNetUsers { get; set; }
    }
}
