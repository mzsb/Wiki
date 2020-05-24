using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Wiki.BLL.Helpers;
using Wiki.BLL.Model.ClaimData;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class VideoClaimDataItemViewModel : ClaimDataItemViewModel
    {
        public string Source
        #region get; set;
        {
            get => Get(ref _source);
            set => Set(ref _source, value);
        }
        private string _source = string.Empty;
        #endregion

        public VideoClaimDataItemViewModel(VideoClaimData videoClaimData) 
            : base(videoClaimData)
        {
            Source = videoClaimData.Source;
        }
    }
}
