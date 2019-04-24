using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage
{
    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [Phone]
        [Display(Name = "تلفن تماس")]
        public string PhoneNumber { get; set; }
    }
}
