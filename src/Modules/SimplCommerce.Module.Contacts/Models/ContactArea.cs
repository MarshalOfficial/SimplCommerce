using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Contacts.Models
{
    public class ContactArea : EntityBase
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
    }
}
