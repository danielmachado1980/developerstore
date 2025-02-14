using Ambev.DeveloperEvaluation.Application.Sales.CreateSaleItem;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;
/// <summary>
/// Represents a request to create a new sale in the system.
/// </summary>
public class CreateSaleRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required Guid CustomerId { get; set; }
    public string? Branch { get; set; }
    public bool IsCancelled { get; set; } = false;
    public List<CreateSaleItemRequest> Items { get; set; }
}