using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpSurvivalKit.Presentation;
using System.Web;
using System.Collections.Specialized;

namespace MvpSurvivalKit.Web
{
    public class NavigationService : INavigationService
    {
        public void GoTo(View.ViewPages viewPages)
        {
            GoTo(viewPages, null);
        }

        public void GoTo(View.ViewPages viewPages, NameValueCollection parameters)
        {
            HttpContext currentContext = HttpContext.Current;
            string redirectUrl = string.Empty;

            switch (viewPages)
            {
                case MvpSurvivalKit.View.ViewPages.Products:
                    redirectUrl = "~/Products.aspx";
                    break;
                case MvpSurvivalKit.View.ViewPages.ProductDetail:
                    redirectUrl = "~/ProductDetail.aspx";
                    break;
                case MvpSurvivalKit.View.ViewPages.Confirmation:
                    redirectUrl = "~/Confirmation.aspx";
                    break;
                case MvpSurvivalKit.View.ViewPages.SessionNotFound:
                    redirectUrl = "~/SessionNotFound.aspx";
                    break;
                default:
                    throw new ArgumentOutOfRangeException("viewPages");
            }

            currentContext.Response.Redirect(redirectUrl, true);
        }
    }
}