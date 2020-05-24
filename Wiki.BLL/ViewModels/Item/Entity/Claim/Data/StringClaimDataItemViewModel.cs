using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Wiki.BLL.Model.ClaimData;

namespace Wiki.BLL.ViewModels
{
    [Bindable(true)]
    public class StringClaimDataItemViewModel : ClaimDataItemViewModel
    {
        public StringClaimDataItemViewModel(StringClaimData stringClaimData)
            : base(stringClaimData) { }
    }
}
