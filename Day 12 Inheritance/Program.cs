using System;
using System.Linq;

class Person
{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person() { }
	public Person(string firstName, string lastName, int identification)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = identification;
	}
	public void printPerson()
	{
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
	}
}

class Student : Person
{
	private int[] testScores;
    private int[] scores;

    public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
    {
        this.scores = scores;
    }

    internal string Calculate()
    {
		double averageScore = scores.Average();
		if (averageScore >= 90) return "O";
		if (averageScore >= 80) return "E";
		if (averageScore >= 70) return "A";
		if (averageScore >= 55) return "P";
		if (averageScore >= 40) return "D";

		return $"T";
    }

    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here

    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
}

class Solution
{
	static void Main()
	{
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
		string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
		int[] scores = new int[numScores];
		for (int i = 0; i < numScores; i++)
		{
			scores[i] = Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}