using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Catalog.Areas.Catalog.ViewModels
{
    public class ProductAttributeFormVm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "پر کردن این قسمت اجباری است")]
        public long GroupId { get; set; }
    }
}
