using Ambev.DeveloperEvaluation.Common.Security;
using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required Guid CustomerId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string? Branch { get; set; }
        public decimal TotalAmount { get; set; }
        public bool IsCancelled { get; set; } = false;
        public List<SaleItem> Items { get; set; }
        public decimal Discount { get; set; }
    }
}
