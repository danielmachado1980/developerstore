using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public class UpdateSaleResult
{
    /// <summary>
    /// The unique identifier of the Sale
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The Sale's full name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The Sale's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The Sale's phone number
    /// </summary>
    public string Phone { get; set; } = string.Empty;   

    ///// <summary>
    ///// The Sale's role in the system
    ///// </summary>
    //public SaleRole Role { get; set; }

    ///// <summary>
    ///// The current status of the Sale
    ///// </summary>
    //public SaleStatus Status { get; set; }
}
