using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wiki.BLL.Commands;
using Wiki.BLL.Helpers;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Model;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class EntityPageViewModel : ViewModelBase
    {
        private readonly string _currentLanguage
            = (System.Globalization.CultureInfo.CurrentCulture).TwoLetterISOLanguageName;
        private const string _defaultLanguage = "en";
        private readonly IEntityService _entityService;

        public EntityPageViewModel(IEntityService entityService)
        {
            _entityService = entityService;
        }

        public EntityItemViewModel EntityItemViewModel
        #region get; set;
        {
            get => Get(ref _entityItemViewModel);
            set => Set(ref _entityItemViewModel, value);
        }
        private EntityItemViewModel _entityItemViewModel = new EntityItemViewModel();
        #endregion

        public ObservableCollection<string> Languages
        #region get; set;
        {
            get => Get(ref _languages);
            set => Set(ref _languages, value);
        }
        private ObservableCollection<string> _languages = new ObservableCollection<string>();
        #endregion

        public async Task PageLoaded()
        {
            await LoadEntity("Q1");
        }

        public async Task LoadEntity(string id)
        {
            if (!Languages.Contains(_currentLanguage))
            {
                Languages.Add(_currentLanguage);
            }

            //for Uno
            if (!Languages.Contains("hu"))
            {
                Languages.Add("hu");
            }

            if (!Languages.Contains(_defaultLanguage))
            {
                Languages.Add(_defaultLanguage);
            }

            EntityItemViewModel.Clear();

            await EntityItemViewModel.InitializeAsync(
                await _entityService.GetByIdAsync(id, Languages.ToList()),
                async (entity) => await _entityService.LoadClaimsAsync(entity, Languages.ToList()),
                _currentLanguage);

            EntityItemViewModel.SetCommand(async (EntityClaimDataItemViewModel entity)
                                                => await LoadEntity(entity.Id));

            EntityItemViewModel.SetCommand(async (QuantityClaimDataItemViewModel quantity)
                                                => await LoadEntity(quantity.UnitId));

            EntityItemViewModel.SetCommand((ImageClaimDataItemViewModel image)
                                                => OpenInBrowser(image.Source));
        }

        public Action<string> OpenInBrowser { get; set; } = new Action<string>((url) => { });
    }
}
