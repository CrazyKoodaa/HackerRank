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

class Result
{
 
    public static int bitwiseAnd(int N, int K)
    {
        // List<int> listResults = new List<int>();
        int result = 0;

        for (int i = 1; i <= N; i++)
        {
            for (int j = i + 1; j <= N; j++)
            {
                int tempResult = i & j;
                if (tempResult > 0 && tempResult < K && tempResult > result)
                {
                    result = tempResult;
                }
            }
        }
        
        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //var varEnv = @"C:\shared\Projekte\Programmieren\!github\HackerRank\Day 29 Bitwise AND";
        //Environment.SetEnvironmentVariable("OUTPUT_PATH", varEnv);
        //var path = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            //textWriter.WriteLine(res);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
