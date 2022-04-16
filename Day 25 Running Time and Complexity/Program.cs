using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int numbersToCheck = Convert.ToInt32(Console.ReadLine());

        // int numbersToCheck = 1;
        while (numbersToCheck-- > 0)
        { 
            int number = Convert.ToInt32(Console.ReadLine());
            if (Prime(number))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");

            
	    };
    }

    private static bool Prime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var maxSquareRoot = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= maxSquareRoot; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}

/* 
33 not prime
31 prime
1000000000 not prime
1000000001 not prime
1000000002 not prime
1000000003 not prime
1000000004 not prime
1000000005 not prime
1000000006 not prime
1000000007 prime
1000000008 not prime
1000000009 prime
*/