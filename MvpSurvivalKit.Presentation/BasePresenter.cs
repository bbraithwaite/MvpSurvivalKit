using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvpSurvivalKit.View;

namespace MvpSurvivalKit.Presentation
{
    public abstract class BasePresenter<TView> where TView : class, IView
    {
        private readonly TView _view;

        private readonly INavigationService _navigationService;

        public BasePresenter(TView view)
        {
            if (view == null) throw new ArgumentNullException("view");
            _view = view;
        }

        public BasePresenter(TView view, INavigationService navigationService)
        {
            if (view == null) throw new ArgumentNullException("view");
            if (navigationService == null) throw new ArgumentNullException("navigationService");
            _view = view;
            _navigationService = navigationService;
        }

        public TView View
        {
            get
            {
                return _view;
            }
        }

        public INavigationService Navigation
        {
            get
            {
                return _navigationService;
            }
        }

        public abstract void Initialize();
    }
}
