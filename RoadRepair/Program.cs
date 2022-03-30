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



class Result
{

    /*
     * Complete the 'getMinCost' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY crew_id
     *  2. INTEGER_ARRAY job_id
     */

    public static long getMinCost(List<int> crew_id, List<int> job_id)
    {
        var cost = 0;
        crew_id.Sort();
        job_id.Sort();

        var len_crew = crew_id.Count;
        var len_job = job_id.Count;

        if (len_crew == len_job)
        {
            for (int i = 0; i < len_crew; i++)
            {
                if (job_id[i] >= crew_id[i])
                    cost = cost + (Math.Abs(job_id[i] - crew_id[i]));
                else if (crew_id[i] < crew_id[i])
                    cost = cost + (Math.Abs(crew_id[i] - job_id[i]));
            }
        }

        return cost;
    }

}

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


class Result
{

    /*
     * Complete the 'getMinCost' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY crew_id
     *  2. INTEGER_ARRAY job_id
     */

    public static long getMinCost(List<int> crew_id, List<int> job_id)
    {
        var cost = 0;
        var costtemp = 0;
        crew_id.Sort();
        job_id.Sort();

        var len_crew = crew_id.Count;
        var len_job = job_id.Count;

        if (len_crew == len_job)
        {
            for (var i = 0; i < len_crew; i++)
            {


                //Console.Error.Write($"Crew {crew_id[i]} - Job {job_id[i]}");
                //costtemp = Math.Abs(job_id[i] - crew_id[i]);
                cost += (Math.Abs(job_id[i] - crew_id[i]));
                //Console.Error.WriteLine($"- cost = {costtemp} - sum: {cost}");
                //Console.Error.WriteLine($"check: {crew_id[i] - job_id[i]}");
            }
        }

        return cost;
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int crew_idCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> crew_id = new List<int>();

        for (int i = 0; i < crew_idCount; i++)
        {
            int crew_idItem = Convert.ToInt32(Console.ReadLine().Trim());
            crew_id.Add(crew_idItem);
        }

        int job_idCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> job_id = new List<int>();

        for (int i = 0; i < job_idCount; i++)
        {
            int job_idItem = Convert.ToInt32(Console.ReadLine().Trim());
            job_id.Add(job_idItem);
        }

        long result = Result.getMinCost(crew_id, job_id);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}


class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int crew_idCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> crew_id = new List<int>();

        for (int i = 0; i < crew_idCount; i++)
        {
            int crew_idItem = Convert.ToInt32(Console.ReadLine().Trim());
            crew_id.Add(crew_idItem);
        }

        int job_idCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> job_id = new List<int>();

        for (int i = 0; i < job_idCount; i++)
        {
            int job_idItem = Convert.ToInt32(Console.ReadLine().Trim());
            job_id.Add(job_idItem);
        }

        long result = Result.getMinCost(crew_id, job_id);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
