using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;
using SimplCommerce.Module.Core.Models;

namespace SimplCommerce.Module.Inventory.Models
{
    public class Warehouse : EntityBase
    {
        public Warehouse() { }

        public Warehouse(long id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Name { get; set; }

        public long AddressId { get; set; }

        public long? VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public Address Address { get; set; }
    }
}
