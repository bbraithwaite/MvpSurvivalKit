using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvpSurvivalKit.Services
{
    public class CheckoutSummary
    {
        private const decimal DiscountRate = 0.10m;

        private const decimal DiscountThreshold = 10m;

        public IEnumerable<Product> Products { get; set; }

        public decimal SubTotal 
        {
            get
            {
                return this.Products.Sum(p => p.UnitPrice);
            }
        }

        public decimal Discount 
        {
            get
            {
                return (SubTotal > DiscountThreshold) ? SubTotal / 1 - (DiscountRate * 100) : 0;
            }
        }

        public decimal Total 
        {
            get
            {
                return SubTotal - Discount;
            }
        }
    }
}
