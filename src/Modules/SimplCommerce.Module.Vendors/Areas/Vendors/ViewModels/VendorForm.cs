using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Vendors.Areas.Vendors.ViewModels
{
    public class VendorForm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Slug { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Email { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public IList<VendorManager> Managers { get; set; } = new List<VendorManager>();
     
    }
}
