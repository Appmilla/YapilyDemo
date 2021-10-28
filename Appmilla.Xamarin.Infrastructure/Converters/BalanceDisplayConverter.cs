using System;
using System.Globalization;
using Xamarin.Forms;

namespace Appmilla.Xamarin.Infrastructure.Converters
{
    /*
     Math.sign(positive); // 1
Math.sign(negative); // -1
Math.sign(zero); // 0
     */
    public class BalanceDisplayConverter : IValueConverter
    {
        public object Credit { get; set; }
        public object Debit { get; set; }
        public object Zero { get; set; }
        public object None { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is double balance)) return None;
            
            try
            {
                var balanceType = Math.Sign(balance);

                switch (balanceType)
                {
                    case 1:
                        return Credit;
                    case 0:
                        return Zero;
                    case -1:
                        return Debit;
                }
            }
            catch (Exception)
            {
            }

            return None;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}