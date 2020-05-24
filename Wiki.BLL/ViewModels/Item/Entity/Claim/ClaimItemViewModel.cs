using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Wiki.BLL.Model.ClaimData;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class ClaimItemViewModel : ViewModelBase
    {
        public ClaimItemViewModel(KeyValuePair<IClaimData, List<IClaimData>> pair, string currentLanguage)
        {
            Predicate = new EntityClaimDataItemViewModel(pair.Key as EntityClaimData, currentLanguage);

            foreach (var claimData in pair.Value)
            {
                var claimDataItemViewModel = ClaimDataItemViewModel.GetSpecific(claimData, currentLanguage);
                claimDataItemViewModel.SetQualifiers(claimData, currentLanguage);
                claimDataItemViewModel.SetReferences(claimData, currentLanguage);
                Objects.Add(claimDataItemViewModel);
            }
        }

        public EntityClaimDataItemViewModel Predicate
        #region get; set;
        {
            get => Get(ref _predicate);
            set => Set(ref _predicate, value);
        }
        private EntityClaimDataItemViewModel _predicate 
            = new EntityClaimDataItemViewModel();
        #endregion

        public ObservableCollection<ClaimDataItemViewModel> Objects
        #region get; set;
        {
            get => Get(ref _objects);
            set => Set(ref _objects, value);
        }
        private ObservableCollection<ClaimDataItemViewModel> _objects 
            = new ObservableCollection<ClaimDataItemViewModel>();
        #endregion

        public string PredicateSortProperty => Predicate.Label;

        public string ObjectsSortProperty => Objects.Any() ? 
                                     Objects.First().Label : 
                                     string.Empty;
    }
}
