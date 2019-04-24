using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [Display(Name = "Name")]
        public string FullName { get; set; }
    }
}
