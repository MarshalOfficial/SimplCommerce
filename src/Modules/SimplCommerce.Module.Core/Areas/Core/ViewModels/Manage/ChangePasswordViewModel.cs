using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "{0} اجباری است")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور فعلی")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "{0} اجباری است")]
        [StringLength(100, ErrorMessage = "رمز عبور بایستی حداقل 6 کاراکتر باشد.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور جدید")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور جدید")]
        [Compare("NewPassword", ErrorMessage = "رمز عبور جدید و تکرار رمز عبور جدید یکسان نیست اند.")]
        public string ConfirmPassword { get; set; }
    }
}
