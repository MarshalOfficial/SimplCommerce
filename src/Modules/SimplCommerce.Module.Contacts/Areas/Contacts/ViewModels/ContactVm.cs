using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Contacts.Areas.Contacts.ViewModels
{
    public class ContactVm
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [EmailAddress(ErrorMessage = "آدرس ایمیل صحیح نیست")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Address { get; set; }

        public string Content { get; set; }

        public long ContactAreaId { get; set; }

        public IList<ContactAreaVm> ContactAreas { get; set; } = new List<ContactAreaVm>();

        public CompanyInformation Company { get; set; }
    }
}
