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
    public class ImageClaimDataItemViewModel : ClaimDataItemViewModel, IInteractable
    {
        public string Source
        #region get; set;
        {
            get => Get(ref _source);
            set => Set(ref _source, value);
        }
        private string _source = string.Empty;
        #endregion

        public DelegateCommand Command
        #region get; set;
        {
            get => Get(ref _command);
            set => Set(ref _command, value);
        }
        private DelegateCommand _command = new DelegateCommand(() => { });
        #endregion

        public ImageClaimDataItemViewModel(ImageClaimData imageClaimData) 
            : base(imageClaimData)
        {
            Source = imageClaimData.Source;
        }
    }
}
