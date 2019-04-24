using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace SimplCommerce.Module.News.Areas.News.ViewModels
{
    public class NewsItemForm
    {
        public NewsItemForm()
        {
            IsPublished = true;
        }

        public long Id { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string Slug { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeywords { get; set; }

        public string MetaDescription { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string ShortContent { get; set; }

        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        public string FullContent { get; set; }

        public bool IsPublished { get; set; }

        public string ThumbnailImageUrl { get; set; }

        public IList<long> NewsCategoryIds { get; set; } = new List<long>();

        public IFormFile ThumbnailImage { get; set; }
    }
}
