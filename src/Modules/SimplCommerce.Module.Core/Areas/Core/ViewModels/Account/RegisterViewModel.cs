using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [Display(Name = "Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(100, ErrorMessage = "کلمه عبور بایستی حداقل 4 کاراکتر باشد", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "کلمه عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار کلمه عبور")]
        [Compare("Password", ErrorMessage = "کلمه عبور و تکرار کلمه عبور یکسان نیستند")]
        public string ConfirmPassword { get; set; }
    }
}
