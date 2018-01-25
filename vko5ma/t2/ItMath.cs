using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace t2
{
    class ItMath
    {
        public static bool OnkoPvm(string syote)
        {
            DateTime parsedDate;
            DateTime parsedDate2;
            bool result = DateTime.TryParseExact(syote, "d. M. yyyy", null, DateTimeStyles.AllowWhiteSpaces, out parsedDate);
            bool result2 = DateTime.TryParseExact(syote, "d. M. yy", null, DateTimeStyles.AllowWhiteSpaces, out parsedDate2);
            if (result || result2)
                return true;
            else
                return false;
        }
    }
}
