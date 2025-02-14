using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Command for update a Sale by their ID
/// </summary>
public record UpdateSaleCommand : IRequest<UpdateSaleResult>
{
    /// <summary>
    /// The unique identifier of the Sale to retrieve
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Initializes a new instance of GetSaleCommand
    /// </summary>
    /// <param name="id">The ID of the Sale to retrieve</param>
    public UpdateSaleCommand(Guid id)
    {
        Id = id;
    }
}
