using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppSouleymaneFaye.Util
{
    public static class CheckEnter
    {
        public static bool checkIsNumber(String number)
        {
            int n;

            return int.TryParse(number, out n);


        }

        public static bool checkIsFloat(String number)
        {
            float n;

            return float.TryParse(number, out n);


        }

        public static (bool success, int result) isInteger(String input)
        {
            int result;
            bool success = int.TryParse(input, out result);
            return (success, result);
        }

        public static (bool success, float result) isFloat(String input)
        {
            float result;
            bool success = float.TryParse(input, out result);
            return (success, result);
        }

        public static bool IsAlphaNumeric(String str)
        {
            // Expression régulière pour exclure les espaces et les caractères spéciaux
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            return regex.IsMatch(str);
        }


    }
}
