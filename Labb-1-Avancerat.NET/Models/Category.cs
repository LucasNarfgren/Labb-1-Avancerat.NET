using System.ComponentModel.DataAnnotations;

namespace Labb_1_Avancerat.NET.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required,MinLength(3),MaxLength(20)]
        public string CategoryName { get; set; }
    }
}
