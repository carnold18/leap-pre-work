using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public static class ExtensionMethods
    {
        // an extension class method must be static
        public static int WordCount(this string str)
        {
            var wordCount = str.Split(new char[] {' ', '.', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
