using System.Collections.ObjectModel;
using System.ComponentModel;
using Wiki.BLL.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Wiki.Shared.UserControls
{
    public sealed partial class Qualifiers : UserControl
    {
        public ObservableCollection<QualifierItemViewModel> Values
        #region { get; set; }
        {
            get => (ObservableCollection<QualifierItemViewModel>)GetValue(ValuesProperty);
            set => SetValue(ValuesProperty, value);
        }

        public static readonly DependencyProperty ValuesProperty =
            DependencyProperty.Register("Values", typeof(ObservableCollection<QualifierItemViewModel>), typeof(Qualifiers), new PropertyMetadata(new ObservableCollection<QualifierItemViewModel>()));
        #endregion

        public Qualifiers()
        {
            this.InitializeComponent();
        }
    }
}
