using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Pricing.Models
{
    public class CatalogRule : EntityBase
    {
        [Required(ErrorMessage = "پر کردن این قسمت اجباری است")]
        [StringLength(450)]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset? StartOn { get; set; }

        public DateTimeOffset? EndOn { get; set; }

        [StringLength(450)]
        public string RuleToApply { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal? MaxDiscountAmount { get; set; }

        public IList<CatalogRuleCustomerGroup> CustomerGroups { get; set; } = new List<CatalogRuleCustomerGroup>();
    }
}
