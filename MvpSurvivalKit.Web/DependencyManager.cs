using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvpSurvivalKit.Services;
using MvpSurvivalKit.Presentation;

namespace MvpSurvivalKit.Web
{
    internal static class DependencyManager
    {
        private static INavigationService _navigationService;

        internal static INavigationService GetNavigationService()
        {
            if (_navigationService == null)
            {
                _navigationService = new NavigationService();
            }

            return _navigationService;
        }

        private static ICheckoutService _checkoutService;

        internal static ICheckoutService GetCheckoutService()
        {
            if (_checkoutService == null)
            {
                _checkoutService = new StubCheckoutService();
            }

            return _checkoutService;
        }
    }
}