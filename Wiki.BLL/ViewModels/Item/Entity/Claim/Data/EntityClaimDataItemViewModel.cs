using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Wiki.BLL.Commands;
using Wiki.BLL.Helpers;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Model.ClaimData;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class EntityClaimDataItemViewModel : ClaimDataItemViewModel, IInteractable
    {

        public string Id
        #region get; set;
        {
            get => Get(ref _id);
            set => Set(ref _id, value);
        }
        private string _id = string.Empty;
        #endregion

        public ObservableCollection<string> OtherLanguageLabels
        #region get; set;
        {
            get => Get(ref _otherLanguageLabels);
            set => Set(ref _otherLanguageLabels, value);
        }
        private ObservableCollection<string> _otherLanguageLabels = new ObservableCollection<string>();
        #endregion

        public string OtherLanguageLabelsStringList => OtherLanguageLabels.ToList().ToString(", ");

        public DelegateCommand Command
        #region get; set;
        {
            get => Get(ref _command);
            set => Set(ref _command, value);
        }
        private DelegateCommand _command = new DelegateCommand(() => { });
        #endregion

        public EntityClaimDataItemViewModel()
            : base(new EntityClaimData { Label = string.Empty, 
                                         Rank = string.Empty }) { }

        public EntityClaimDataItemViewModel(EntityClaimData entityClaimData,
                                            string currentLanguage)
            : base(entityClaimData)
        {
            Id = entityClaimData.Id;
            Label = entityClaimData.Labels.GetStringValue(currentLanguage, "en");
            if (entityClaimData.Labels.Count > 1) {
                foreach (var label in entityClaimData.Labels.Values.Select(l => l.Value))
                {
                    if (label != Label)
                    {
                        OtherLanguageLabels.Add(label);
                    }
                }
            }
        }
    }
}
