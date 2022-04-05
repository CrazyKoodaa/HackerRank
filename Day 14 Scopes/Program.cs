using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;
    private int[] a;



    // Add your code here
    public Difference(int[] array) => elements = array;
    public void computeDifference()
    {
        maximumDifference = elements.Max() - elements.Min();
    }
}


class Solution
{
static void Main(string[] args)
{
    var x = Convert.ToInt32(Console.ReadLine());

    int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

    Difference d = new Difference(a);

    d.computeDifference();

    Console.Write(d.maximumDifference);
}
}