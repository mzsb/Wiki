using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class References : UserControl
    {
        public ObservableCollection<ReferenceItemViewModel> Values
        #region { get; set; }
        {
            get => (ObservableCollection<ReferenceItemViewModel>)GetValue(ValuesProperty);
            set => SetValue(ValuesProperty, value);
        }

        public static readonly DependencyProperty ValuesProperty =
            DependencyProperty.Register("Values", typeof(ObservableCollection<ReferenceItemViewModel>), typeof(References), new PropertyMetadata(new ObservableCollection<ReferenceItemViewModel>()));
        #endregion

        public References()
        {
            this.InitializeComponent();
        }
    }
}
