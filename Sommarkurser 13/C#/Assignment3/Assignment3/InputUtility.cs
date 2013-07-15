using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// File: InputUtility.cs
/// Name: Tim Fielding
/// Date: 08/07/2013

namespace Assignment3
{
    /// <summary>
    /// Assists the input part of the program
    /// </summary>
    class InputUtility
    {
        /// <summary>
        /// Tries to parse the doubleOut parameter, returns true and changed the value of doubleOut if succeeded, otherwise not
        /// </summary>
        /// <param name="toConvert"></param>
        /// <param name="doubleOut"></param>
        /// <returns></returns>
        public static bool GetDouble(string toConvert, out double doubleOut)
        {
            return double.TryParse(toConvert, out doubleOut);
        }
        /// <summary>
        /// The methods below checks if the input is valid (non-empty string, non-zero numbers)
        /// </summary>
        /// <param name="toCheck"></param>
        /// <returns></returns>
        public static bool ValidateString(string toCheck)
        {
            return !string.IsNullOrEmpty(toCheck);
        }

        public static bool ValidateDouble(double number)
        {
            return !(number >= 0.0d);
        }
    }
}
