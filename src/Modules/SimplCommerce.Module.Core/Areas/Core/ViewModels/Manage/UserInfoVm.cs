using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage
{
    public class UserInfoVm
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Email { get; set; }
    }
}
