using System;
using System.Collections.Generic;
using System.Text;
using Uno;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Wiki.Shared.StyleSelectors
{
    public class ClaimDataItemContainerStyleSelector : StyleSelector
    {
        public Style White { get; set; }
        public Style Blue { get; set; }

        private bool _white = false;

        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
            _white = !_white;

            if (_white)
            {
                return White;
            }
            else
            {
                return Blue;
            }
        }
    }
}
