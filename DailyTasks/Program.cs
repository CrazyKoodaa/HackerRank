using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyTasks
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            string result = "";
            Console.WriteLine(n);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
                result = i + " " + result;
            }
            Console.WriteLine(result.TrimEnd());
            
            //if (n != 0)
            //        result += arr[i] + " ";
            //    else
            //        result += arr[i];

        }
    }

}
