using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Wiki.BLL.Model.ClaimData;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class ClaimDataItemViewModel : ViewModelBase
    {
        public string Label
        #region get; set;
        {
            get => Get(ref _label);
            set => Set(ref _label, value);
        }
        private string _label = string.Empty;
        #endregion

        public string Rank
        #region get; set;
        {
            get => Get(ref _rank);
            set => Set(ref _rank, value);
        }
        private string _rank = string.Empty;
        #endregion

        public ObservableCollection<QualifierItemViewModel> Qualifiers
        #region get; set;
        {
            get => Get(ref _qualifiers);
            set => Set(ref _qualifiers, value);
        }
        private ObservableCollection<QualifierItemViewModel> _qualifiers
            = new ObservableCollection<QualifierItemViewModel>();
        #endregion

        public ObservableCollection<ReferenceItemViewModel> References
        #region get; set;
        {
            get => Get(ref _references);
            set => Set(ref _references, value);
        }
        private ObservableCollection<ReferenceItemViewModel> _references
            = new ObservableCollection<ReferenceItemViewModel>();
        #endregion

        public ClaimDataItemViewModel(IClaimData claimData)
        {
            Label = claimData.Label;
            Rank = claimData.Rank;
        }

        public void SetQualifiers(IClaimData claimData, string currrentLanguage) =>
            Qualifiers = new ObservableCollection<QualifierItemViewModel>(
                claimData.Qualifiers.Select(pair => new QualifierItemViewModel(pair, currrentLanguage))
                                    .ToList());

        public void SetReferences(IClaimData claimData, string currrentLanguage) =>
            References = claimData.References.Any() ? 
                         new ObservableCollection<ReferenceItemViewModel>(
                     claimData.References.First()
                                         .Select(pair => new ReferenceItemViewModel(pair, currrentLanguage))
                                         .ToList()) : 
                     References;

        public static ClaimDataItemViewModel GetSpecific(IClaimData claimData, string currentLanguage)
        {
            if (claimData is EntityClaimData entityClaimData)
            {
                return new EntityClaimDataItemViewModel(entityClaimData, currentLanguage);
            }
            else if (claimData is StringClaimData stringClaimData)
            {
                return new StringClaimDataItemViewModel(stringClaimData);
            }
            else if (claimData is QuantityClaimData quantityClaimData)
            {
                return new QuantityClaimDataItemViewModel(quantityClaimData, currentLanguage);
            }
            else if (claimData is ImageClaimData imageClaimData)
            {
                return new ImageClaimDataItemViewModel(imageClaimData);
            }
            else if (claimData is AudioClaimData audioClaimData)
            {
                return new AudioClaimDataItemViewModel(audioClaimData);
            }
            else if (claimData is VideoClaimData videoClaimData)
            {
                return new VideoClaimDataItemViewModel(videoClaimData);
            }
            else if (claimData is UnknownClaimData unknownClaimData)
            {
                return new UnknownClaimDataItemViewModel(unknownClaimData);
            }

            return null;
        }
    }
}
