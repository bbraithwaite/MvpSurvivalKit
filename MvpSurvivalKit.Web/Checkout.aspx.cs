using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MvpSurvivalKit.Presentation;
using MvpSurvivalKit.View;
using MvpSurvivalKit.Services;

namespace MvpSurvivalKit.Web
{
    public partial class Checkout : System.Web.UI.Page, ICheckoutView
    {
        private CheckoutPresenter _presenter;

        public string SessionID
        {
            get { return Request.QueryString["si"]; }
        }

        public IList<ProductItem> Products
        {
            set
            {
                this.uiProducts.DataSource = value;
                this.uiProducts.DataBind();
            }
        }

        public string CardNumber
        {
            get { return this.uxCardNumber.Text; }
        }

        public string CustomerName
        {
            get { return this.uxCustomerName.Text; }
        }

        public decimal SubTotal
        {
            set { this.uiSubTotal.Text = ConvertToCurrentString(value); }
        }

        public decimal Discount
        {
            set { this.uiDiscount.Text = ConvertToCurrentString(value); }
        }

        public decimal Total
        {
            set { this.uiTotal.Text = ConvertToCurrentString(value); }
        }

        public Checkout()
        {
            _presenter = new CheckoutPresenter(this, 
                                            DependencyManager.GetNavigationService(), 
                                            DependencyManager.GetCheckoutService());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter.Initialize();
        }

        public static string ConvertToCurrentString(decimal value)
        {
            return value.ToString("c");
        }

        protected void uxCheckout_Click(object sender, EventArgs e)
        {
            _presenter.Checkout();
        }
    }
}