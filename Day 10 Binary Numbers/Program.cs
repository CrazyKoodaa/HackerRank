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



class Solution
{
    public static void Main(string[] args)
    {
        // int n = Convert.ToInt32(Console.ReadLine().Trim());
        int n = 13;
        string bin = Convert.ToString(n, 2);
        int countingOnes = 0, maxOnes = 0;
        for (int i = 0; i < bin.Length; i++)
        {
            if (bin[i] == '1')
            {
                countingOnes++;
                if (maxOnes < countingOnes) maxOnes = countingOnes;
            }
            else
            {
                countingOnes = 0;
            }

        }
        Console.WriteLine(maxOnes);
    }
}
