using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvpSurvivalKit.Services
{
    /// <summary>
    /// This is a stub implementation of the checkout service. Typically a database would power this data.
    /// </summary>
    public class StubCheckoutService : ICheckoutService
    {
        private const string SessionID = "E6A621A3-E90B-4566-8E03-62D23549F9D4";

        public IList<Product> GetProducts(string sessionID)
        {
            IList<Product> products = new List<Product>();

            return products;
        }

        public void Checkout(CheckoutPaymentDetail checkoutDetail)
        {
            
        }

        public CheckoutSummary GetSummary(string sessionID)
        {
            if (sessionID == SessionID)
            {
                CheckoutSummary summary = new CheckoutSummary();

                IList<Product> products = new List<Product>();
                products.Add(new Product() { ProductName = "Apples", UnitPrice = 2.55m });
                products.Add(new Product() { ProductName = "Pears", UnitPrice = 1.99m });
                products.Add(new Product() { ProductName = "Soup", UnitPrice = 2.49m });
                products.Add(new Product() { ProductName = "Steak", UnitPrice = 4.99m });

                summary.Products = products;

                return summary;
            }

            return null;
        }
    }
}
