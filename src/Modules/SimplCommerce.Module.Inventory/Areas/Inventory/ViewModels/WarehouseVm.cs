using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Inventory.Areas.Inventory.ViewModels
{
    public class WarehouseVm
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }

        public long AddressId { get; set; }

        public string ContactName { get; set; } 

        public string Phone { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public long? DistrictId { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "منطقه یا استان اجباری است")]
        public long StateOrProvinceId { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string CountryId { get; set; }
    }
}
