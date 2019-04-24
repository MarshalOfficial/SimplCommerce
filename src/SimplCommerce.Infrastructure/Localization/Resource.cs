using SimplCommerce.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Infrastructure.Localization
{
    public class Resource : EntityBase
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Key { get; set; }

        public string Value { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string CultureId { get; set; }

        public Culture Culture { get; set; }
    }
}
