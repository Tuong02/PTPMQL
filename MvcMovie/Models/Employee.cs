namespace MvcMovie.Models
{
    public class Employee : Person
    { 
        public string PersonId { get; set; }
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
