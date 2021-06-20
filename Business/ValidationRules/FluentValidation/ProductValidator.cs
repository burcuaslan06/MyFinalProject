using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün isim bilgisi girmelisiniz.");
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Ürün ismi en az iki karakterden oluşmalıdır.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Ürün kategori bilgisi girmelisiniz.");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Ürün fiyatı bilgisi girmelisiniz.");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Ürün fiyat bilgisi 0 olamaz");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Ürün Stok adedi bilgisi girmelisiniz. ");
           
            // RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); //a ile başlamallı

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
