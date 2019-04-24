using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Contacts.Areas.Contacts.ViewModels
{
    public class ContactAreaForm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }
    }
}
