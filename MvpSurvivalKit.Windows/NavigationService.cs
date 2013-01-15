using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvpSurvivalKit.Presentation;

namespace MvpSurvivalKit.Windows
{
    public class NavigationService : INavigationService
    {
        public void GoTo(View.ViewPages viewPages)
        {
            switch (viewPages)
            {
                case MvpSurvivalKit.View.ViewPages.Products:
                    break;
                case MvpSurvivalKit.View.ViewPages.ProductDetail:
                    break;
                case MvpSurvivalKit.View.ViewPages.Confirmation:
                    break;
                case MvpSurvivalKit.View.ViewPages.SessionNotFound:
                    break;
                default:
                    break;
            }
        }
    }
}
