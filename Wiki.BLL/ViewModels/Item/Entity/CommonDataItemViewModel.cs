using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Wiki.BLL.Helpers;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class CommonDataItemViewModel : ViewModelBase
    {
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

        public ObservableCollection<string> Aliases
        #region get; set;
        {
            get => Get(ref _aliases);
            set => Set(ref _aliases, value);
        }
        private ObservableCollection<string> _aliases 
            = new ObservableCollection<string>();
        #endregion

        public string AliasesStringList => Aliases.ToList()
                                                  .ToString(", ");

        public string SiteLink
        #region get; set;
        {
            get => Get(ref _siteLink);
            set => Set(ref _siteLink, value);
        }
        private string _siteLink = string.Empty;
        #endregion
    }
}
