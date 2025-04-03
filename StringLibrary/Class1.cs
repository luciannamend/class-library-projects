using System;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        /// <summary>
        /// This method returns a Boolean value that indicates whether the current
        /// string instance begins with an uppercase character. The Unicode standard
        /// distinguishes uppercase characters from lowercase characters.
        /// The Char.IsUpper(Char) method returns true if a character is uppercase.
        /// </summary>


        // StartsWithUpper() is implemented as an extension method so that you 
        // can call it as if it were a member of the String class. 
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}