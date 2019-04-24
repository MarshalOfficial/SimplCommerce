using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.PaymentStripe.Areas.PaymentStripe.ViewModels
{
    public class StripeConfigForm
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string PublicKey { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string PrivateKey { get; set; }
    }
}
