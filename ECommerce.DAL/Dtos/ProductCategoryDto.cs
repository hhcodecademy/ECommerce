using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Dtos
{
    public class ProductCategoryDto:BaseDto
    {
        public Guid ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
