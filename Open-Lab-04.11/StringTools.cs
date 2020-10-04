using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] ret = str.ToCharArray();
            Array.Sort(ret);
            return new string(ret);
        }
    }
}
