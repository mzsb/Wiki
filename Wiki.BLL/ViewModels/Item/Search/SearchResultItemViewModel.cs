using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Wiki.BLL.Model;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class SearchResultItemViewModel : ViewModelBase
    {

        public SearchResultItemViewModel(SearchResult searchResult)
        {
            Label = searchResult.Label;
            Description = searchResult.Description;
            Id = searchResult.Id;
        }

        public string Label
        #region get; set;
        {
            get => Get(ref _label);
            set => Set(ref _label, value);
        }
        private string _label = string.Empty;
        #endregion

        public string Description
        #region get; set;
        {
            get => Get(ref _description);
            set => Set(ref _description, value);
        }
        private string _description = string.Empty;
        #endregion

        public string Id
        #region get; set;
        {
            get => Get(ref _id);
            set => Set(ref _id, value);
        }
        private string _id = string.Empty;
        #endregion
    }
}
