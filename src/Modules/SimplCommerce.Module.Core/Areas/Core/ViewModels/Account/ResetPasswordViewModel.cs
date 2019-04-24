using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Account
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(100, ErrorMessage = "کلمه عبور بایستی حداقل 4 کاراکتر باشد", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare("Password", ErrorMessage = "کلمه عبور و تکرار کلمه عبور یکسان نیستند")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
