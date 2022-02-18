using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidatin
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün ismi boş olamaz");
            RuleFor(p => p.ProductName).Length(2, 30);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);

            //RuleFor(p => p.ProductName).Must(StartWithWitA);
        }

        //private bool StartWithWitA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}