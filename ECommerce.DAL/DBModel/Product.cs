﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.DBModel
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Rating { get; set; }
        public decimal Stock { get; set; }
        public string Brand { get; set; }

        public Guid ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string Thumbnail { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }    

    }
}
