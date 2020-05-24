using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace Wiki.Shared.Converters
{
    public class CollectionIsEmptyToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
            => value is ICollection collection ? collection.Count > 0 : false;

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
