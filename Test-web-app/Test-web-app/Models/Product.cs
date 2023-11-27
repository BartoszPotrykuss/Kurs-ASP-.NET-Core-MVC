using System.ComponentModel.DataAnnotations;

namespace Test_web_app.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole nazwa jest wymagane")]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
