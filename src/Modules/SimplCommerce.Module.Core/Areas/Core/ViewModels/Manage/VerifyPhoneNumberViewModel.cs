using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage
{
    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Code { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [Phone]
        [Display(Name = "تلفن تماس")]
        public string PhoneNumber { get; set; }
    }
}
