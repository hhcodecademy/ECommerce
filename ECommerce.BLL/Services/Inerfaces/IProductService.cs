﻿using ECommerce.DAL.DBModel;
using ECommerce.DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services.Inerfaces
{
    public interface IProductService : IGenericService<ProductDto, Product>
    {
        public Task<List<ProductCategoryDto>> GetCategoriesAsync();

        public Task<List<ProductDto>> GetProductsByCategoryIdAsync(Guid id);
        public Task<ProductDto> GetProductDetailByIdAsync(Guid id);
    }
}
