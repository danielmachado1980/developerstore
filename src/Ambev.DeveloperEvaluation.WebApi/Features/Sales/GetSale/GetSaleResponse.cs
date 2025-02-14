using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

/// <summary>
/// API response model for GetUser operation
/// </summary>
public class GetSaleResponse
{
    /// <summary>
    /// The unique identifier of the sale
    /// </summary>
    public Guid Id { get; set; }
    public required Guid CustomerId { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string? Branch { get; set; }
    public decimal TotalAmount { get; set; }
    public bool IsCancelled { get; set; } = false;
    public List<SaleItem> Items { get; set; }
    public decimal Discount { get; set; }
}
