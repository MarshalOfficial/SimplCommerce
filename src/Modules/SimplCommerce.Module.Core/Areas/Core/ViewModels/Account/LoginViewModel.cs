using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "پر کردن مقدار ایمیل اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده صحیح نیست")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار؟")]
        public bool RememberMe { get; set; }
    }
}
