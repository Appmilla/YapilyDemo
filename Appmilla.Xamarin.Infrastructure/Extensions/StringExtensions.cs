using System;
using System.Globalization;
using System.Linq;

namespace Appmilla.Xamarin.Infrastructure.Extensions
{
    public static class StringUtilities
    {
        public static string GetCurrencySymbol(string code)  
        {  
            RegionInfo regionInfo = (from culture in CultureInfo.GetCultures(CultureTypes.AllCultures)  
                where culture.Name.Length > 0 && !culture.IsNeutralCulture  
                let region = new RegionInfo(culture.LCID)  
                where String.Equals(region.ISOCurrencySymbol, code, StringComparison.InvariantCultureIgnoreCase)  
                select region).First();  
  
            return regionInfo.CurrencySymbol;  
        }
    }
    public static class StringExtensions
    {
        // from http://ninja-code.co.uk/how-to-return-currency-symbol-from-currency-code-using-c/
        /// <summary>  
        /// Method used to return a currency symbol.  
        /// It receive as a parameter a currency code (3 digits).  
        /// </summary>  
        /// <param name="code">3 digits code. Samples GBP, BRL, USD, etc.</param>  
        public static string GetCurrencySymbol(this string s, string code)  
        {  
            System.Globalization.RegionInfo regionInfo = (from culture in System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes.InstalledWin32Cultures)  
                where culture.Name.Length > 0 && !culture.IsNeutralCulture  
                let region = new System.Globalization.RegionInfo(culture.LCID)  
                where String.Equals(region.ISOCurrencySymbol, code, StringComparison.InvariantCultureIgnoreCase)  
                select region).First();  
  
            return regionInfo.CurrencySymbol;  
        }
    }
}