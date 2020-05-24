using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Wiki.BLL.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Wiki.Shared.UserControls
{
    public sealed partial class ClaimObject : UserControl
    {

        public ClaimDataItemViewModel ClaimData
        #region { get; set; }
        {
            get => (ClaimDataItemViewModel)GetValue(ClaimDataProperty);
            set => SetValue(ClaimDataProperty, value);
        }

        public static readonly DependencyProperty ClaimDataProperty =
            DependencyProperty.Register("ClaimData", typeof(ClaimDataItemViewModel), typeof(ClaimObject), new PropertyMetadata(null));
        #endregion

        public object InnerContent
        #region { get; set; }
        {
            get { return GetValue(InnerContentProperty); }
            set { SetValue(InnerContentProperty, value); }
        }

        public static readonly DependencyProperty InnerContentProperty =
            DependencyProperty.Register("InnerContent", typeof(object), typeof(ClaimObject), new PropertyMetadata(null));
        #endregion

        public ClaimObject()
        {
            this.InitializeComponent();
        }
    }
}
