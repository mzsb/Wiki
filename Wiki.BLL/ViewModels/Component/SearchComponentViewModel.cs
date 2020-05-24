using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Wiki.BLL.Interfaces;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class SearchComponentViewModel : ViewModelBase
    {
        public ObservableCollection<SearchResultItemViewModel> SearchResultItemViewModels { get; set; } = new ObservableCollection<SearchResultItemViewModel>();

        private readonly ISearchService _searchService;

        public SearchComponentViewModel(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public async Task SearchEntity(string searchKey, string language = "en")
        {
            var searchResults = await _searchService.SearchEntitiesAsync(searchKey, language)
                                                    .ConfigureAwait(false);

            SearchResultItemViewModels.Clear();
            foreach (var item in searchResults)
            {
                SearchResultItemViewModels.Add(new SearchResultItemViewModel(item));
            }
        }
    }
}
