using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvpSurvivalKit.Presentation
{
    public interface INavigationService
    {
        void GoTo(View.ViewPages viewPages);
    }
}
