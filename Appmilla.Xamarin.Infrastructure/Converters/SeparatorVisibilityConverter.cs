using System;
using System.Collections;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appmilla.Xamarin.Infrastructure.Converters
{
    public class SeparatorVisibilityConverter : IMarkupExtension, IValueConverter 
    { 
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) 
                return false;
            
            var showSeparator = true;
            
            if (parameter is StackLayout stackLayout)
            {
                var itemsSource = BindableLayout.GetItemsSource(stackLayout);

                if (!(itemsSource is IList itemsList)) return true;
            
                showSeparator = itemsList[0]!= value;
            }
            else if (parameter is ListView listView)
            {
                var itemsSource = listView.ItemsSource;
                
                if (!(itemsSource is IList itemsList)) return true;
                
                showSeparator = itemsList[0]!= value;
            }
            else if (parameter is CollectionView collectionView)
            {
                var itemsSource = collectionView.ItemsSource;

                if (!(itemsSource is IList itemsList)) return true;

                showSeparator = itemsList[0] != value;
            }

            return showSeparator;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        
        public object ProvideValue(IServiceProvider serviceProvider) => this;
    } 
}