using AutoMapper;
using ECommerce.BLL.Services.Inerfaces;
using ECommerce.DAL.DBModel;
using ECommerce.DAL.Dtos;
using ECommerce.DAL.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services
{
    public class ProductService : GenericService<ProductDto, Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IGenericRepository<ProductCategory> _categoryRepository;
        private readonly IGenericRepository<ProductImage> _documentRepository;
        public ProductService(IGenericRepository<Product> genericRepository,
            IMapper mapper, ILogger<GenericService<ProductDto, Product>> logger,
            IGenericRepository<ProductCategory> categoryRepository, IProductRepository productRepository, IGenericRepository<ProductImage> documentRepository)
            : base(genericRepository, mapper, logger)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
            _documentRepository = documentRepository;
        }


        /// <summary>
        /// Get product categories with current product
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductCategoryDto>> GetCategoriesAsync()
        {

            var categories = await _categoryRepository.GetListAsync();

            var categoryDtos = _mapper.Map<List<ProductCategoryDto>>(categories);
            return categoryDtos;
        }

        public async Task<ProductDto> GetProductDetailByIdAsync(Guid id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            List<ProductImage> documents = await _documentRepository.GetListAsync();
            product.ProductImages = documents.Where(d => d.ProductId == id).ToList();
            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }

        public async Task<List<ProductDto>> GetProductsByCategoryIdAsync(Guid id)
        {
            var products = await _productRepository.GetByCategoryIdAsync(id);
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;
        }
    }
}
