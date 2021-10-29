using System.Globalization;

namespace Appmilla.Xamarin.Infrastructure.Extensions
{
    public static class DoubleExtensions
    {
        /*
        public static string ToFormattedCurrencyString(this double value)
        {
            var formatter = (NumberFormatInfo)new CultureInfo("en-GB").NumberFormat.Clone();
            formatter.CurrencyNegativePattern = 1;

            return value.ToString("c", formatter);
        }
        */
        
        public static string ToFormattedCurrencyString(this double value, string currencySymbol)
        {
            var formatter = (NumberFormatInfo)new CultureInfo("en-GB").NumberFormat.Clone();
            formatter.CurrencyNegativePattern = 1;
            formatter.CurrencySymbol = currencySymbol;
            
            return value.ToString("c", formatter);
        }
        
        public static string ToFormattedCurrencyString(this double? value, string currencySymbol)
        {
            var formatter = (NumberFormatInfo)new CultureInfo("en-GB").NumberFormat.Clone();
            formatter.CurrencyNegativePattern = 1;
            formatter.CurrencySymbol = currencySymbol;
            
            return value?.ToString("c", formatter);
        }
    }
}