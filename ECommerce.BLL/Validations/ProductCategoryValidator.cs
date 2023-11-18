using ECommerce.DAL.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Validations
{
    public class ProductCategoryValidator: AbstractValidator<ProductCategoryDto>
    {
        public ProductCategoryValidator()
        {
            RuleFor(d => d.Name).NotNull().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz")
                .NotEmpty().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz");
        }
    }
  
}
