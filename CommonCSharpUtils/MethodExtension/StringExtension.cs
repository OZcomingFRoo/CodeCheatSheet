using System;
using System.Collections.Generic;
using System.Text;

namespace CommonCSharpUtils.MethodExtension
{
    public static class StringExtension
    {
        /// <summary>
        /// Essentially, the opposite of "string.IsNullOrEmpty" to make boolean statements much shorter <br/>
        /// Very common in production applications
        /// </summary>
        /// <param name="str">The string value</param>
        /// <returns>Checks if value is not: Null, empty or white-spaced</returns>
        public static bool IsSet(this string str)
        {
            return string.IsNullOrEmpty(str) == false;
        }
    }
}
