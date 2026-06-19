using System.ComponentModel.DataAnnotations;

namespace Pizza.Data.Models
{
    public class AdminLogin
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
