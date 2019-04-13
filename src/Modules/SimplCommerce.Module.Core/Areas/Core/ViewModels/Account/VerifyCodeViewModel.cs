using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Account
{
    public class VerifyCodeViewModel
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Provider { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "آیا این مرورگر ذخیره شود؟")]
        public bool RememberBrowser { get; set; }

        [Display(Name = "مرا بخاطر بسپار؟")]
        public bool RememberMe { get; set; }
    }
}
