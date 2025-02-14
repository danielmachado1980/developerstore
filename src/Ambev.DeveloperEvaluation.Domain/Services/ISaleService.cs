using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Services
{
    public interface ISaleService
    {
        void Restriction(int quantity);
        decimal CalculateDiscount(int quantity);
    }
}
