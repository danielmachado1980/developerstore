using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public class GetSaleResult
{
    /// <summary>
    /// The unique identifier of the Sale
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();
    public required Guid CustomerId { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string? Branch { get; set; }
    public decimal TotalAmount { get; set; }
    public bool IsCancelled { get; set; } = false;
    public List<SaleItem> Items { get; set; }
    public decimal Discount { get; set; }

}
