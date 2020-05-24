using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.BLL.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;

namespace Wiki.Shared.TemplateSelectors
{
    public class ClaimDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Entity { get; set; }
        public DataTemplate String { get; set; }
        public DataTemplate Quantity { get; set; }
        public DataTemplate Image { get; set; }
        public DataTemplate Video { get; set; }
        public DataTemplate Audio { get; set; }
        public DataTemplate Unknown { get; set; }

        protected override DataTemplate SelectTemplateCore(object itemViewModel)
        {
            if(itemViewModel is EntityClaimDataItemViewModel)
            {
                return Entity;
            }
            else if (itemViewModel is StringClaimDataItemViewModel)
            {
                return String;
            }
            else if (itemViewModel is QuantityClaimDataItemViewModel)
            {
                return Quantity;
            }
            else if (itemViewModel is ImageClaimDataItemViewModel)
            {
                return Image;
            }
            else if (itemViewModel is VideoClaimDataItemViewModel)
            {
                return Video;
            }
            else if (itemViewModel is AudioClaimDataItemViewModel)
            {
                return Audio;
            }
            else
            {
                return Unknown;
            }
        }
    }
}
