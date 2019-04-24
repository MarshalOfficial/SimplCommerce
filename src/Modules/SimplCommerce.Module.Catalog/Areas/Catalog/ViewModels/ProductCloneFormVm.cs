using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels
{
    public class ProductCloneFormVm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Slug { get; set; }
    }
}
