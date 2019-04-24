using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Tax.Models
{
    public class TaxClass : EntityBase
    {
        public TaxClass() { }

        public TaxClass(long id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Name { get; set; }
    }
}
