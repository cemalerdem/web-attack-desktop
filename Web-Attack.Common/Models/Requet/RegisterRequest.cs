﻿using System.ComponentModel.DataAnnotations;

namespace Web_Attack.Common.Models.Requet
{
    public class RegisterRequest
    {
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }
        [Required]
        [StringLength(25)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string ConfirmPassword { get; set; }
    }
}