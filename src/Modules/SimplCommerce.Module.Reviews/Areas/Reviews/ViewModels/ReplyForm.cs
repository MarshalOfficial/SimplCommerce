using System.ComponentModel.DataAnnotations;

namespace SimplCommerce.Module.Reviews.Areas.Reviews.ViewModels
{
    public class ReplyForm
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Comment { get; set; }

        public string ReplierName { get; set; }

        public long ReviewId { get; set; }
    }
}
