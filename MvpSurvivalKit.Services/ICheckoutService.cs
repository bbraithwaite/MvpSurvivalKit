using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvpSurvivalKit.Services
{
    public interface ICheckoutService
    {
        IList<Product> GetProducts(string sessionID);
        void Checkout(CheckoutPaymentDetail checkoutDetail);
        CheckoutSummary GetSummary(string p);
    }
}
