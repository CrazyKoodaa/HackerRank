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

        List<List<int>> arr = new List<List<int>>();
        /*
        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }*/
/*
 * 
 * 0 -4 -6 0 -7 -6
-1 -2 -6 -8 -3 -1
-8 -4 -2 -8 -8 -6
-3 -1 -2 -5 -7 -4
-3 -5 -3 -6 -6 -6
-3 -6 0 -8 -6 -7

        */

        arr.Add("0 -4 -6 0 -7 -6".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        arr.Add("-1 -2 -6 -8 -3 -1".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        arr.Add("-8 -4 -2 -8 -8 -6".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        arr.Add("-3 -1 -2 -5 -7 -4".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        arr.Add("-3 -5 -3 -6 -6 -6".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        arr.Add("-3 -6 0 -8 -6 -7".TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        foreach (var item in arr)
        {
            Console.WriteLine();
            foreach (var item2 in item)
                Console.Write(item2 + " ");

        }
        Console.WriteLine();
        // Console.WriteLine(arr[0][0]);
        int maxSum = -9999;

        for (int i = 1; i < 5 ; i++)
            for (int j = 1; j < 5 ; j++)
            {
                int tempSum = checkSurrounding(arr, i, j);
                if ( tempSum > maxSum)
                    maxSum = tempSum;
            }


        Console.WriteLine(maxSum);

    }

    public static int checkSurrounding(List<List<int>> myArray, int x, int y)
    {
        int sum = 0;

        sum += myArray[x-1][y-1];
        sum += myArray[x-1][y];
        sum += myArray[x-1][y+1];
        sum += myArray[x]  [y];
        sum += myArray[x+1][y-1];
        sum += myArray[x+1][y];
        sum += myArray[x+1][y+1];

        return sum;

    }
}
