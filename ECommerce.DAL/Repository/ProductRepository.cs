using ECommerce.DAL.Data;
using ECommerce.DAL.DBModel;
using ECommerce.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(AppDbIdentityContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Product>> GetByCategoryIdAsync(Guid id)
        {
            IQueryable<Product> products = _dbContext.Products.Where(p => p.ProductCategoryId == id);
            return products.ToList();
        }
    }
}
