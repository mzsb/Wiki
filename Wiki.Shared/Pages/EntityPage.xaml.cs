using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Wiki.BLL.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Wiki.Shared.Pages
{
    public sealed partial class EntityPage : Page
    {
        private readonly EntityPageViewModel viewModel;

        public EntityPage()
        {
            this.InitializeComponent();

            viewModel = App.serviceProvider.GetRequiredService<EntityPageViewModel>();

            DataContext = viewModel;

            Loaded += async (object sender, RoutedEventArgs args) => await viewModel.PageLoaded();

            viewModel.OpenInBrowser = async (url) => await Windows.System.Launcher.LaunchUriAsync(new Uri(url));
        }

        public Func<string, Task> LoadEntity => viewModel.LoadEntity;

        private void SortByPredicate(object sender, PointerRoutedEventArgs args) => 
            viewModel.EntityItemViewModel.Claims
                = new ObservableCollection<ClaimItemViewModel>(
                    viewModel.EntityItemViewModel.Claims.OrderBy(c => c.PredicateSortProperty));

        private void SortByObject(object sender, PointerRoutedEventArgs args) =>
            viewModel.EntityItemViewModel.Claims
                = new ObservableCollection<ClaimItemViewModel>(
                    viewModel.EntityItemViewModel.Claims.OrderBy(c => c.ObjectsSortProperty));
    }
}
