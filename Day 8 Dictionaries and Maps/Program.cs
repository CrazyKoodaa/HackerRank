using System;
using System.Collections.Generic;
using System.IO;
class Day_8_Dictionaries_and_Maps
{
    static void Main(String[] args)
    {
        // { (new string("sam"), 9991222), ("tom", 11122222), ("harry", 21231321) }
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        //phoneBook.Add("sam", 123123123);

        int numberOfPhones = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> phoneBook = new Dictionary<string, int>();

        for (int i = 0; i < numberOfPhones; i++)
        {
            string[] nameAndPhonenumber = Console.ReadLine().Split(' ');
            phoneBook.Add(nameAndPhonenumber[0], Convert.ToInt32(nameAndPhonenumber[1]));
        }


        for (int i = 0; i < numberOfPhones; i++)
        {
            string tempName = Console.ReadLine();
            if (phoneBook.ContainsKey(tempName))
            {
                phoneBook.TryGetValue(tempName, out int value);
                Console.WriteLine($"{tempName}={value}");
            }
            else
                Console.WriteLine("Not found");



        }


    }
}
