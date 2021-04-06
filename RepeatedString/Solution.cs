using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

public class Solution

{
    static long repeatedString(string s, long n)
    {
        long result = 0;
        if (s.Contains('a'))
        {
            char ch = 'a';
            long stringLength = s.Length;
            int freqA = Regex.Matches(s, ch.ToString()).Count;
            int remainderValue = (int)(n % stringLength);

            result = (n / stringLength) * freqA;

            if (remainderValue != 0)
                result += Regex.Matches(s.Substring(0, remainderValue), ch.ToString()).Count;

        }

        return result;
    }
    //static void Main(string[] args)
    //{
    //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //    string s = Console.ReadLine();

    //    long n = Convert.ToInt64(Console.ReadLine());

    //    long result = repeatedString(s, n);

    //    textWriter.WriteLine(result);

    //    textWriter.Flush();
    //    textWriter.Close();
    //}
}
