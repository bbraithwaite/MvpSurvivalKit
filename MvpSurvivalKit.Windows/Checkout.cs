using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MvpSurvivalKit.View;
using MvpSurvivalKit.Presentation;
using MvpSurvivalKit.Services;

namespace MvpSurvivalKit.Windows
{
public partial class Checkout : Form, ICheckoutView
{
    private readonly string _sessionID;

    private CheckoutPresenter _presenter;

    public Checkout(string sessionID)
    {
        this._sessionID = sessionID;
        _presenter = new CheckoutPresenter(this, new NavigationService(), new StubCheckoutService());
        InitializeComponent();
    }

    public string SessionID
    {
        get { return this._sessionID; }
    }

    public IList<ProductItem> Products
    {
        set 
        {
            this.uiProducts.DataSource = value;
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

    public static string ConvertToCurrentString(decimal value)
    {
        return value.ToString("c");
    }

    private void uxCheckout_Click(object sender, EventArgs e)
    {
        _presenter.Checkout();
    }

    private void Checkout_Load(object sender, EventArgs e)
    {
        _presenter.Initialize();
    }
    }
}
