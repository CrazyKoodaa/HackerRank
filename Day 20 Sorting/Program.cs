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
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Track number of elements swapped during a array traversal
        int numberOfSwaps = 0;
        // Write your code here
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    swap(a, j, j + 1);
                    numberOfSwaps++;
                }
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }
        Console.WriteLine($@"Array is sorted in {numberOfSwaps} swaps.
First Element: {a[0]}
Last Element: {a[n-1]}");
    }

    private static void swap(List<int> a, int j, int v)
    {
        var temp = a[j];
        a[j] = a[v];
        a[v] = temp;
    }
}
