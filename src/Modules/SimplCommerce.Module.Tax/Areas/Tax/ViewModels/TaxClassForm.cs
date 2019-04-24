using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Tax.Areas.Tax.ViewModels
{
    public class TaxClassForm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }
    }
}
