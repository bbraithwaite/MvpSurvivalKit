using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvpSurvivalKit.View;
using MvpSurvivalKit.Services;

namespace MvpSurvivalKit.Presentation
{
    public class CheckoutPresenter : BasePresenter<ICheckoutView>
    {
        private readonly ICheckoutService _checkoutService;

        public CheckoutPresenter(ICheckoutView view, INavigationService navigationService, ICheckoutService checkoutService)
            : base(view, navigationService)
        {
            _checkoutService = checkoutService;
        }

        public override void Initialize()
        {
            // get the checkout summary from the Model
            CheckoutSummary summary = _checkoutService.GetSummary(View.SessionID);

            if (summary != null)
            {
                IList<ProductItem> productItems = new List<ProductItem>();

                foreach (Product item in summary.Products)
                {
                    productItems.Add(new ProductItem() { ProductName = item.ProductName, UnitPrice = item.UnitPrice });
                }

                // set the properties to be displayed to the View
                View.Products = productItems;
                View.SubTotal = summary.SubTotal;
                View.Discount = summary.Discount;
                View.Total = summary.Total;
            }
            else
            {
                Navigation.GoTo(ViewPages.SessionNotFound);
            }
        }

        public void Checkout()
        {
            // take payment and authorise
            CheckoutPaymentDetail checkoutDetail = new CheckoutPaymentDetail();
            checkoutDetail.CardNumber = View.CardNumber;
            checkoutDetail.CustomerName = View.CustomerName;

            _checkoutService.Checkout(checkoutDetail);

            // redirect to confirmation page
            Navigation.GoTo(ViewPages.Confirmation);
        }
    }
}
