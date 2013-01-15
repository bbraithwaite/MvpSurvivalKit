using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvpSurvivalKit.View
{
    public interface ICheckoutView : IView
    {
        string SessionID { get; }
        IList<ProductItem> Products { set; }
        string CardNumber { get; }
        string CustomerName { get; }
        decimal SubTotal { set; }
        decimal Discount { set; }
        decimal Total { set; }
    }
}
