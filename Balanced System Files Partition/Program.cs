using System;
using System.Collections.Generic;

namespace Balanced_System_Files_Partition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] parent = { -1, 0, 0, 1, 1, 2 };
            int[] files_size = { 1, 2, 2, 1, 1, 1 };
            //int[] parent = { -1, 0, 1, 2 };
            //int[] files_size = { 1, 4, 3, 4 };
            int[] sizes = new int[parent.Length];
            int current, smallestDelta;

            // int[,] treeVsSize = new int[parent.Length, 2];
            // int totalSize = 0;
            
            for (int i = 0; i < parent.Length; i++)
            {
                current = i;
                while (current != -1)
                { 
                    sizes[current] += files_size[i];
                    current = parent[current];
                } 
            }

            //for (int i = 0; i < sizes.Length; i++)
            //{
            //    Console.WriteLine($"Tree {parent[i]} = {sizes[i]}");
            //}

            smallestDelta = Math.Abs(sizes[0] - 2 * sizes[1]);
            for (int i = 0; i < sizes.Length; i++)
            {
                int tempSmallestDelta = Math.Abs(sizes[0] - 2 * sizes[i]);
                // Console.WriteLine($"Temp Smallest Delta = {tempSmallestDelta}");
                if (smallestDelta > tempSmallestDelta)
                    smallestDelta = tempSmallestDelta;
            }
            Console.Write($"Smallest Delta should be = ");
            Console.WriteLine(smallestDelta);


            //double halved = sizes[0] / 2;
            //int rememberPos = 0;
            //bool found = false;

            //for (int i = 0; i < sizes.Length; i++)
            //{
            //    if (sizes[i] == halved)
            //    {
            //        Console.WriteLine($"Found halved in tree {i}, Therefore Delta = 0");
            //        found = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"No halved in the tree {i}. Trying to find the smallest delta");
            //        if (sizes[i] > halved)
            //        {
            //            rememberPos = i;
            //            Console.WriteLine($"Delta Size to next +1 number {Math.Abs(sizes[rememberPos] - sizes[rememberPos + 1])}");
            //            // Console.WriteLine($"Delta Size to next -1 number {Math.Abs(sizes[rememberPos] - sizes[rememberPos - 1])}");
            //        }
            //    }
            //    // 12 11 (6) 4 1
            //}
            //Console.WriteLine($"Position Remembered: {rememberPos}");
            //Console.WriteLine($"Size of RemPos: {sizes[rememberPos]}");

            //for (int i = parent.Length - 1; i > 0 ; i--)
            //{
                
            //}
            
            /*
             * Tree Size like this:
             *          0/1                 -1
             *    1/2       2/2             0   0
             * 3/1  4/1         5/1        1 1   2
             * 
             * or 
             * 
             * -1
             * |- 0
             *    |- 1
             *    |- 1
             * |-0
             *    |- 2
             */

                // how to create this tree...
                // if the number exists 2 in parent, then it's another subtree


                /*
                /*
                 *  root 0 = 1 + 2 + 2 + 1 + 1 + 1  = 8
                 *      tree 0-0 = 2 + 1 + 1        = 4
                 *          tree 0-0-0 1            = 1
                 *          tree 0-0-1 1            = 1
                 *      tree 0-1 = 1 + 1            = 2 
                 *  
                 *  total = 8
                 *  halved = 4
                 *  check for 4 and cut the other tree
                 * 
                 * 
                 */

                // OR

                

                /*
                 * Tree Size looks like this:
                 *              0/1     true
                 *              1/4     true
                 *              2/3     false
                 *              3/4     false
                 *              
                 *              
                 *              12 / 2 = 6
                 *              solve 2
                 */






        }
    }
}
