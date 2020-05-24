using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Wiki.BLL.Commands;
using Wiki.BLL.Helpers;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Model.ClaimData;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class QuantityClaimDataItemViewModel : ClaimDataItemViewModel, IInteractable
    {
        public string UnitId
        #region get; set;
        {
            get => Get(ref _unitId);
            set => Set(ref _unitId, value);
        }
        private string _unitId = string.Empty;
        #endregion

        public string Amount
        #region get; set;
        {
            get => Get(ref _amount);
            set => Set(ref _amount, value);
        }
        private string _amount = string.Empty;
        #endregion

        public DelegateCommand Command
        #region get; set;
        {
            get => Get(ref _command);
            set => Set(ref _command, value);
        }
        private DelegateCommand _command = new DelegateCommand(() => { });
        #endregion

        public QuantityClaimDataItemViewModel(QuantityClaimData quantityClaimData,
                                              string currentLanguage) 
            : base(quantityClaimData)
        {
            UnitId = quantityClaimData.Unit?.Id;
            Label = quantityClaimData.Unit?.Labels
                                           .GetStringValue(currentLanguage) 
                                           ?? Label;
            Amount = quantityClaimData.Amount.First() == '+' ? 
                       quantityClaimData.Amount.Remove(0, 1) :
                       quantityClaimData.Amount;
        }
    }
}
