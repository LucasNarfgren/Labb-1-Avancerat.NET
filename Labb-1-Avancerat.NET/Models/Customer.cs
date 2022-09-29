using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb_1_Avancerat.NET.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="This field is required"),MinLength(3),MaxLength(25)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required"), MinLength(5), MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required"),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
