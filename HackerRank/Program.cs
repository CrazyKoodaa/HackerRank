using System;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //
            //
            // Console.WriteLine("Hello World!");
            string s = "caberqiitefg";
            int k = 5;
            int startOfMaxVowels = 0;
            int maxVowels = 0;
            int numberOfVowels = 0;
            
            for (int startingPos = 0; startingPos < s.Length - k; startingPos++)
            {
                numberOfVowels = 0;
                for (int i = startingPos; i < startingPos + k; i++)
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        // Console.WriteLine(s[i]);
                        numberOfVowels++;
                    }
                    // else
                        // Console.WriteLine("nope");
                }
                if (maxVowels < numberOfVowels)
                {
                    maxVowels = numberOfVowels;
                    startOfMaxVowels = startingPos;
                }
                // Console.WriteLine(" ");
            }
            // Console.WriteLine($"Starting Pos is {startOfMaxVowels} with {maxVowels}");
            if (numberOfVowels == 0)
                Console.WriteLine("Not found!");
            else
            {
                int endOfMaxVowels = startOfMaxVowels + 5;

                Console.WriteLine($"{s[startOfMaxVowels..endOfMaxVowels]}");

            }
// Console.WriteLine(s[1]);
        }
    }
}
