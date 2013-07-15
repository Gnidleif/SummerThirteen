using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// InputUtility.cs
// Tim Fielding 08/07/2013

namespace Assignment4
{
    /// <summary>
    /// Class to handle checking of input from the user
    /// </summary>
    class InputUtility
    {
        public static bool GetDouble(string toConvert, out double outDouble)
        {
            return double.TryParse(toConvert, out outDouble);
        }

        public static bool GetInt(string toConvert, out int outInt)
        {
            return int.TryParse(toConvert, out outInt);
        }

        public static bool ValidateString(string toCheck)
        {
            return !string.IsNullOrEmpty(toCheck);
        }

        public static bool ValidateDouble(double toCheck)
        {
            return toCheck > 0.0d;
        }

        public static bool ValidateInteger(int toCheck)
        {
            return toCheck > 0;
        }
    }
}
