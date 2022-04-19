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
        // int N = Convert.ToInt32(Console.ReadLine().Trim());
#region myTestPart
        List<string> names = new List<string>();

        string[] inputstrings =
        {
            "riya riya@gmail.com",
"julia julia@julia.me",
"julia sjulia@gmail.com",
"julia julia@gmail.com",
"samantha samantha@gmail.com",
"tanya tanya@gmail.com",
"riya ariya@gmail.com",
"julia bjulia@julia.me",
"julia csjulia@gmail.com",
"julia djulia@gmail.com",
"samantha esamantha@gmail.com",
"tanya ftanya@gmail.com",
"riya riya@live.com",
"julia julia@live.com",
"julia sjulia@live.com",
"julia julia@live.com",
"samantha samantha@live.com",
"tanya tanya@live.com",
"riya ariya@live.com",
"julia bjulia@live.com",
"julia csjulia@live.com",
"julia djulia@live.com",
"samantha esamantha@live.com",
"tanya ftanya@live.com",
"riya gmail@riya.com",
"priya priya@gmail.com",
"preeti preeti@gmail.com",
"alice alice@alicegmail.com",
"alice alice@gmail.com",
"alice gmail.alice@gmail.com",
        };
        #endregion

        for (int NItr = 0; NItr < inputstrings.Length; NItr++)
        {
            //changed to above array
            string[] firstMultipleInput = inputstrings[NItr].ToString().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];
            if (emailID.Contains("@gmail.com"))
                names.Add(firstName);
        }

        names.Sort();
        foreach (var name in names)
            Console.WriteLine(name);
    }
}
