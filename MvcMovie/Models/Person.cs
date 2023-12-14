using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "PersonId khong duoc de trong")]
        public string PersonID { get; set; }
        [Required(ErrorMessage ="Full name is required")]
        public string FullName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Address { get; set; }
    }
}