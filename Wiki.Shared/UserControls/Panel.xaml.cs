using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Wiki.Shared.UserControls
{
    public sealed partial class Panel : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public object InnerContent
        #region { get; set; }
        {
            get { return GetValue(InnerContentProperty); }
            set { SetValue(InnerContentProperty, value); }
        }

        public static readonly DependencyProperty InnerContentProperty =
            DependencyProperty.Register("InnerContent", typeof(object), typeof(Panel), new PropertyMetadata(null));
        #endregion

        public object Header
        #region { get; set; }
        {
            get => GetValue(HeaderProperty);
            set => SetValue(HeaderProperty, value);
        }

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(object), typeof(Panel), new PropertyMetadata(new object()));
        #endregion

        public bool IsOpenable
        #region { get; set; }
        {
            get => (bool)GetValue(IsOpenableProperty);
            set => SetValue(IsOpenableProperty, value);
        }

        public static readonly DependencyProperty IsOpenableProperty =
            DependencyProperty.Register("IsOpenable", typeof(bool), typeof(Panel), new PropertyMetadata(true));
        #endregion

        private bool _isOpen = false;

        public bool IsOpen
        {
            get => _isOpen;
            set
            {
                _isOpen = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsOpen)));
            }
        }

        public Panel()
        {
            this.InitializeComponent();
        }

        private void Clicked(object sender, RoutedEventArgs args)
        {
            IsOpen = !IsOpen;
            if (sender is Button button)
            {
                button.Content = char.ConvertFromUtf32(IsOpen ? 0xE738 : 0xE710);
            }
        }
    }
}
