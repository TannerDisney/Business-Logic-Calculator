using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            string pattern = @"\b\d{3}[-]\d{2}[-]\d{4}\b";
            string pattern2 = @"\b\d{9}\b";
            Regex rx = new Regex(pattern);
            Regex rx2 = new Regex(pattern2);
            if (rx.IsMatch(ssn) || rx2.IsMatch(ssn))
            {
                return true;
            }
            else if (ssn.Length == 9 || (ssn.Length == 11 && rx.IsMatch(ssn)))
            {
                return true;
            }
            return false;

        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if (minValue <= numToTest && maxValue >= numToTest)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
