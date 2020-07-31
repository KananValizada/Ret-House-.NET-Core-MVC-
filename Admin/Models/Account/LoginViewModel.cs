using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-poçt vacibdir")]
        [EmailAddress(ErrorMessage = "Düzgün E-poçt daxil edin")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifrə vacibdir")]
        [MinLength(6, ErrorMessage = "Şifrə minimum 6 xarakter olmalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
