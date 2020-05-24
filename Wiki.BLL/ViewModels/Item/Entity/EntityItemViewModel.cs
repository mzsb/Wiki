using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.BLL.Commands;
using Wiki.BLL.Helpers;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Model;
using Wiki.BLL.Model.ClaimData;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class EntityItemViewModel : ViewModelBase
    {
        public string Label
        #region get; set;
        {
            get => Get(ref _label);
            set => Set(ref _label, value);
        }
        private string _label = string.Empty;
        #endregion

        public ObservableCollection<CommonDataItemViewModel> CommonDatas
        #region get; set;
        {
            get => Get(ref _commonDatas);
            set => Set(ref _commonDatas, value);
        }
        private ObservableCollection<CommonDataItemViewModel> _commonDatas 
            = new ObservableCollection<CommonDataItemViewModel>();
        #endregion

        public ObservableCollection<ClaimItemViewModel> Claims
        #region get; set;
        {
            get => Get(ref _claims);
            set => Set(ref _claims, value);
        }
        private ObservableCollection<ClaimItemViewModel> _claims 
            = new ObservableCollection<ClaimItemViewModel>();
        #endregion

        public void Clear()
        {
            Label = string.Empty;
            Claims.Clear();
            CommonDatas.Clear();
        }

        public async Task InitializeAsync(Entity entity, 
                                          Func<Entity, Task<Dictionary<IClaimData, List<IClaimData>>>> loadClaims,
                                          string currentLanguage)
        {
            Label = entity.Labels.GetStringValue(currentLanguage, "en");

            foreach (var pair in await loadClaims(entity))
            {
                Claims.Add(new ClaimItemViewModel(pair, currentLanguage));
            }

            foreach (var language in entity.Labels.Keys)
            {
                CommonDatas.Add(new CommonDataItemViewModel
                {
                    Label = entity.Labels.GetStringValue(language),
                    Description = entity.Descriptions.GetStringValue(language),
                    SiteLink = entity.SiteLinks.GetStringValue(language),
                    Aliases = 
                    new ObservableCollection<string>(
                        entity.Aliases.TryGetValue(language, out List<Alias> list) ? 
                                                    list.Select(o => o.ToString()) : 
                                                    new List<string>())
                });
            }
        }

        public void SetCommand<T>(Action<T> action) where T : IInteractable
        {
            foreach (var claimItemViewModel in Claims)
            {
                SetCommandToClaimData(claimItemViewModel.Predicate, action);

                foreach (var claimDataItemViewmodel in claimItemViewModel.Objects)
                {
                    SetCommandToClaimData(claimDataItemViewmodel, action);

                    foreach (var qualifier in claimDataItemViewmodel.Qualifiers)
                    {
                        SetCommandToClaimData(qualifier.Predicate, action);

                        foreach (var qualifierObject in qualifier.Objects)
                        {
                            SetCommandToClaimData(qualifierObject, action);
                        }
                    }

                    foreach (var reference in claimDataItemViewmodel.References)
                    {
                        SetCommandToClaimData(reference.Predicate, action);

                        foreach (var referenceObject in reference.Objects)
                        {
                            SetCommandToClaimData(referenceObject, action);
                        }
                    }
                }
            }
        }

        private void SetCommandToClaimData<T>(ClaimDataItemViewModel claimDataItemViewModel, 
                                              Action<T> action) 
            where T : IInteractable
        {
            if (claimDataItemViewModel is T TClaimDataItemViewModel)
            {
                TClaimDataItemViewModel.Command 
                    = new DelegateCommand(() => { action(TClaimDataItemViewModel); });
            }
        }
    }
}
