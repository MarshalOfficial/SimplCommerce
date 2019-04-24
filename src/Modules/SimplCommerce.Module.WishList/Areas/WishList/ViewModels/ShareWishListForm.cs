using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.WishList.Areas.WishList.ViewModels
{
    public class ShareWishListForm
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Message { get; set; }
    }
}
