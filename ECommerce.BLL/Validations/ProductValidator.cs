using ECommerce.DAL.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Validations
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(d => d.Title).NotNull().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz")
                .NotEmpty().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz");
            RuleFor(d => d.Price).NotNull().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz")
                  .NotEmpty().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz"); ;
            RuleFor(d => d.Brand).NotNull().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz")
                  .NotEmpty().WithMessage("Xahiş edirem  {PropertyName} alanı daxil ediniz");
            //  RuleFor(d => d.t).EmailAddress().WithMessage("Xahiş edirem  {PropertyName} alanın düzgün dəyər daxil ediniz"); ;
        }
    }
}
