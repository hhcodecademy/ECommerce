using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.DBModel
{
    public class ProductImage:BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public string Url { get; set; }
    }
}
