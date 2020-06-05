using System.ComponentModel.DataAnnotations;

namespace Web_Attack.Common.Models.Requet
{
    public class LoginRequest
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}