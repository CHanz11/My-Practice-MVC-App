using System.ComponentModel.DataAnnotations;

namespace My_Practice_MVC_App.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name is Required.") ]
        [StringLength(50, ErrorMessage = "Name Cannot Exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is Required.")]
        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120.")]
        public int Age { get; set; }
    }
}
