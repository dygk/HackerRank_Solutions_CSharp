using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Solutions_CSharp.ReplaceAllDigitsWithChars
{
    public class ReplaceAllDigitsWithChars
    {
        public static string ReplaceDigits(string s)
        {

            char[] str = s.ToCharArray();

            for (int i = 1; i < str.Length; i = i + 2)
            {

                str[i] = Shift(str[i - 1], int.Parse(str[i].ToString()));

            }
            string result = new(str);
            return result;

        }

        public static char Shift(char letter, int x)
        {
            char nextChar;
            if (letter == 'z')
                nextChar = 'z';
            else if (letter == 'Z')
                nextChar = 'Z';

            else
                nextChar = (char)((int)letter + x);

            return nextChar;
        }

        static void Main(string[] args)
        {
            ReplaceDigits("a1c1e1");
        }

    }
}
