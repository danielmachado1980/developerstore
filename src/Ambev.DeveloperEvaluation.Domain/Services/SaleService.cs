using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public class SaleService : ISaleService
    {

        public decimal CalculateDiscount(int quantity)
        {
            if (quantity >= 10) return 0.20m;
            if (quantity >= 4) return 0.10m;
            return 0m;
        }

        public void Restriction(int quantity)
        {
            if (quantity < 1) throw new ArgumentException("Quantity must be greater than zero.");
            if (quantity > 20) throw new ArgumentException("Quantity for identical items must be until 20.");

        }
    }
}
