using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SoccerId.Models
{
    public class ModalRegisterLogin
    {
        [Required]
        [EmailAddress]
        [Display(Name = "")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение {0} должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают.")]
        public string PasswordConfirm { get; set; }
    }
}