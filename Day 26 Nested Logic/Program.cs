using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        DateTime dateReturn, dateExpected;
        var returnedDate = Console.ReadLine();
        var expectedDate = Console.ReadLine();

        try { dateReturn = DateTime.ParseExact(returnedDate, "d M yyyy", System.Globalization.CultureInfo.InvariantCulture); }
        catch { dateReturn = DateTime.ParseExact(returnedDate, "d M y", System.Globalization.CultureInfo.InvariantCulture); }

        try { dateExpected = DateTime.ParseExact(expectedDate, "d M yyyy", System.Globalization.CultureInfo.InvariantCulture); }
        catch { dateExpected = DateTime.ParseExact(expectedDate, "d M y", System.Globalization.CultureInfo.InvariantCulture); }

        Console.WriteLine(dTime(dateReturn, dateExpected));
    }
    static int dTime(DateTime returned, DateTime expected)
    {
        if (returned.Year > expected.Year) return 10000;
        if (returned.Month > expected.Month && returned.Year == expected.Year) return (500 * (returned.Month - expected.Month));
        if (returned.Day > expected.Day && returned.Month == expected.Month && returned.Year == expected.Year) return (15 * (returned.Day - expected.Day));
        return 0;
    }
}

//try { dateReturn = DateTime.ParseExact("1 1 1", "d M yyyy", System.Globalization.CultureInfo.InvariantCulture); }
//catch { dateReturn = DateTime.ParseExact("1 1 1", "d M y", System.Globalization.CultureInfo.InvariantCulture); }

//try { dateExpected = DateTime.ParseExact("8 8 8", "d M yyyy", System.Globalization.CultureInfo.InvariantCulture); }
//catch { dateExpected = DateTime.ParseExact("8 8 8", "d M y", System.Globalization.CultureInfo.InvariantCulture); }
