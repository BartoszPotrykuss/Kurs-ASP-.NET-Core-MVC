using System.ComponentModel.DataAnnotations;

namespace Test_web_app.Models
{
    public class Reigster
    {
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
