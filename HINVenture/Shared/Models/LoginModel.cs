using System.ComponentModel.DataAnnotations;

namespace HINVenture.Shared.Models
{
    public class LoginModel
    {
        [Required] public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}