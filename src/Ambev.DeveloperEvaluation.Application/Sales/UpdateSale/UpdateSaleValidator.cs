using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Validator for GetSaleCommand
/// </summary>
public class UpdateSaleValidator : AbstractValidator<UpdateSaleCommand>
{
    /// <summary>
    /// Initializes validation rules for GetSaleCommand
    /// </summary>
    public UpdateSaleValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Sale ID is required");
    }
}
