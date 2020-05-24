using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Wiki.BLL.ViewModels;
using Wiki.Shared.Pages;
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
    public sealed partial class NavMenu : UserControl
    {
        private readonly SearchComponentViewModel viewModel;

        public object InnerContent
        #region { get; set; }
        {
            get { return GetValue(InnerContentProperty); }
            set { SetValue(InnerContentProperty, value); }
        }

        public static readonly DependencyProperty InnerContentProperty =
            DependencyProperty.Register("InnerContent", typeof(object), typeof(NavMenu), new PropertyMetadata(null));
        #endregion

        public Func<string, Task> LoadEntity
        #region { get; set; }
        {
            get => (Func<string, Task>)GetValue(LoadEntityProperty);
            set => SetValue(LoadEntityProperty, value);
        }

        public static readonly DependencyProperty LoadEntityProperty =
            DependencyProperty.Register("LoadEntity", typeof(Func<string, Task>), typeof(NavMenu), new PropertyMetadata(null));
        #endregion

        public NavMenu()
        {
            this.InitializeComponent();
            viewModel = App.serviceProvider.GetRequiredService<SearchComponentViewModel>();
            DataContext = viewModel;
        }

        private async void TextChanged(AutoSuggestBox autoSuggestBox, AutoSuggestBoxTextChangedEventArgs args)
        {
            await viewModel.SearchEntity(autoSuggestBox.Text);
        }

        private async void SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            if (args.SelectedItem is SearchResultItemViewModel viewModel)
            {
                await LoadEntity(viewModel.Id);
            }
        }

        private async void LabelClicked(object sender, RoutedEventArgs args)
        {
            await LoadEntity("Q1");
        }
    }
}
