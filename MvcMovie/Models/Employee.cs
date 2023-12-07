using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string? EmpName { get; set; }
    }
}