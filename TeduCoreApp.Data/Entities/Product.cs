using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Data.Interfaces;
using TeduCoreApp.Infrastructure.SharedKernel;

namespace TeduCoreApp.Data.Entities
{
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public string SeoPageTitle {get; set;}
        public string SeoAlias {get; set;}
        public string SeoKeyWords {get; set;}
        public string SeoDescription {get; set;}
        public DateTime DateCreated {get; set;}
        public DateTime DateModified {get; set;}
        public Status Status {get; set;}
    }
}
