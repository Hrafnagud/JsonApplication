using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDistrictJsonBLL
{
    public static class LanguageCompatibility
    {
        public static string TranslateTurkishCharsToEnglish(string value) {
            return value.Replace("ş", "s").Replace("ö","o").Replace("ı","i").Replace("ç","c").Replace("ğ","g").Replace("ü","u");
        }
    }
}
