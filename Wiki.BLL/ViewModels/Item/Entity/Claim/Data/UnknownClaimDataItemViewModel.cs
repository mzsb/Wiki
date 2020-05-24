using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Wiki.BLL.Model.ClaimData;

namespace Wiki.BLL.ViewModels
{
    public class UnknownClaimDataItemViewModel : ClaimDataItemViewModel
    {
        [Bindable(true)]
        public UnknownClaimDataItemViewModel()
             : base(new EntityClaimData{ Label = string.Empty,
                                         Rank = string.Empty }) { }
        public UnknownClaimDataItemViewModel(UnknownClaimData unknownClaimData)
            : base(unknownClaimData) { }
    }
}
