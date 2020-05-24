using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Wiki.BLL.Model.ClaimData;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class QualifierItemViewModel : ViewModelBase
    {
        public EntityClaimDataItemViewModel Predicate
        #region get; set;
        {
            get => Get(ref _predicate);
            set => Set(ref _predicate, value);
        }
        private EntityClaimDataItemViewModel _predicate = new EntityClaimDataItemViewModel();
        #endregion

        public ObservableCollection<ClaimDataItemViewModel> Objects
        #region get; set;
        {
            get => Get(ref _objects);
            set => Set(ref _objects, value);
        }
        private ObservableCollection<ClaimDataItemViewModel> _objects = new ObservableCollection<ClaimDataItemViewModel>();
        #endregion

        public QualifierItemViewModel(KeyValuePair<IClaimData, List<IClaimData>> pair, string currentLanguage)
        {
            Predicate = new EntityClaimDataItemViewModel(pair.Key as EntityClaimData, currentLanguage);

            foreach (var obj in pair.Value)
            {
                Objects.Add(ClaimDataItemViewModel.GetSpecific(obj, currentLanguage));
            }
        }
    }
}
