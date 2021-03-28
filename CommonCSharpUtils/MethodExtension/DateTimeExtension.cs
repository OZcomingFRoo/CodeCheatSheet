using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCSharpUtils.MethodExtension
{
    public static class DateTimeExtension
    {
        /// <summary>
        /// Utility function used to check if DateTime object is between 2 other DateTime objects. <br/>
        /// The function will automatically recognized which DateTime parameter is bigger than the other.
        /// </summary>
        /// <param name="thisDateTime">The one that checks if it is between the 2</param>
        /// <param name="dt1">DateTime object 1</param>
        /// <param name="dt2">DateTime object 2</param>
        /// <param name="includeEquals">Default is true. if set to true then it will check it the DateTime equals the 2.</param>
        /// <returns>If DateTime is between the 2, then true. Else is false</returns>
        public static bool IsBetween(this DateTime thisDateTime, DateTime dt1, DateTime dt2, bool includeEquals = true)
        {
            DateTime min, max;
            if (dt1 > dt2)
            {
                min = dt2;
                max = dt1;
            }
            else if (dt1 < dt2)
            {
                min = dt1;
                max = dt2;
            }
            else
            {
                return includeEquals && thisDateTime == dt1;
            }
            return (thisDateTime > min && thisDateTime < max) || // Between the two DateTime objects
                   (includeEquals && (thisDateTime == dt1 || thisDateTime == dt2)); // equals to either one
        }
    }
}
