using ECommerce.DAL.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Dtos
{
    public class ProductImageDto:BaseDto
    {
        public Guid ProductId { get; set; }
        public string Url { get; set; }
    }
}
