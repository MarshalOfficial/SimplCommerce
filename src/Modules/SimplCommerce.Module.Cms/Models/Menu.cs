using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Cms.Models
{
    public class Menu : EntityBase
    {
        public Menu()
        {

        }

        public Menu(long id)
        {
            Id = id;
        }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Name { get; set; }

        public bool IsPublished { get; set; }

        public bool IsSystem { get; set; }

        public IList<MenuItem> MenuItems { get; protected set; } = new List<MenuItem>();
    }
}
