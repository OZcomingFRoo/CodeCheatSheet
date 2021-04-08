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

        /// <summary>
        /// Custom string method to check if ALL of the sub-strings provided are inside the string value
        /// </summary>
        /// <param name="str">The string value to check</param>
        /// <param name="subStrings">The list of sub-strings to check if they're inside the string value</param>
        /// <returns>True if all of them are contained in the string, else false</returns>
        public static bool ContainsAll(this string str, params string[] subStrings)
        {
            foreach (var subStr in subStrings)
            {
                if (str.Contains(subStr) == false) return false;
            }
            return true;
        }

        /// <summary>
        /// Custom string method to check if one of the sub-strings provided is inside the string value
        /// </summary>
        /// <param name="str">The string value to check</param>
        /// <param name="subStrings">The list of sub-strings to check if they're inside the string value</param>
        /// <returns>True if one of them is contained in the string, else false</returns>
        public static bool ContainsAny(this string str, params string[] subStrings)
        {
            foreach (var subStr in subStrings)
            {
                if (str.Contains(subStr)) return true;
            }
            return false;
        }

        /// <summary>
        /// Validates that the string value is a valid email address <br/>
        /// Note! It does not validate if the email address is a valid destination to send a message.<br/>
        /// For that, the only real way is to send a message to confirm.
        /// </summary>
        /// <param name="emailStr">The string to check</param>
        /// <returns>True if the string value is a valid email address string, else false</returns>
        public static bool IsValidEmailString(this string emailStr)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(emailStr)) return false;
                var addr = new System.Net.Mail.MailAddress(emailStr);
                return addr.Address == emailStr;
            }
            catch
            {
                return false;
            }
        }
    }
}
