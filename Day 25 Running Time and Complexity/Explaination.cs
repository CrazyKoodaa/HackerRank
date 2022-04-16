using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Day_25_Running_Time_and_Complexity
{
    internal class Program
    {
        public static int findNumsOfRepetitions(String s, char c)
        {
            // The biggest O here is O(n+1), so it is a Linear time; O(n) time

            int sum = 0;                                      //= O(1)
            /* breaking up the for part
             * int i = 0 will be executed once no matter what   =  O(1)
             * i < s.Length will be at lease executed once      =  O(n+1)
             * i++ will executed linear                         =  O(n)
             * 
             * the if Part will be executed everytime           =  O(n)
             */
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) sum++;
            }
            return sum;                                       //= O(1)
        }

        public static int[] findNumsOfRepetitionsV1(String s, char[] c)
        {
            // The biggest O here is O(nm+1) so it's actually a multiplaction but we right now say it's Quad time: O(n*m) time
            int[] sums = new int[c.Length];                 // O(1)
            for (int i = 0; i < s.Length; i++)              // O(1); O(n+1); O(n)                       // n = length of the string in this example
            {
                for (int j = 0; j < c.Length; j++)          // O(n); O(n); O(n)                // because of the nested loop, but
                {                                           // O(n+1); O(nm + 1); O(nm)        // nm + 1 because it really checks at least one time the condition
                    if (s[i] == c[j])                       // O(nm)
                    {
                        sums[j] += 1;                       // O(nm)
                    }
                }
            }
            return sums;                                    // O(1)
        }

        public static int[] findNumsOfRepetitionsV2(String s, char[] c)
        {
            // The Optimal Time would be O(n+m) so Linear Time
            // example:
            // n = 5 length
            // m = 25 length
            //   = 25 ms
            int[] sums = new int[c.Length];                 // O(1)
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], 1);
                }
                else
                {
                    map[s[i]] = map[s[i]] + 1;
                }
            }

            for (int i = 0; i < c.Length; i++)
            {
                int sum;
                if (map.TryGetValue(c[i], out sum))
                {
                    sums[i] = 0;
                }
                else
                {
                    sums[i] = c[i];
                }
            }
            return sums;
        }



        static void explaination(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch sw = new Stopwatch();


            // O(1) -> Constant doesn't depend on input = the best
            /* example:
             * input        time
             * 100          10ms
             * 1000         10ms
             * 10000        10ms
             */

            // O(log(n)) -> logartihmic = also good
            /* example:
             * input        time
             * 16           3ms
             * 200+         4ms
             * +++++        20ms (Which is still pretty quick)
             */

            // O(n) -> linear = slow
            // You have to go through each element once
            /* example:
             * in the above method with for and if: it goes through each element through
             * Size of problem == size of solution => we are doing pretty good
             * 
             */

            // O(n²) -> Quadriatic (Something like nested for loops)
            /* example:
             * input        time
             * 10           100
             * 100          10000
             * 4            16
             */

            string myString = "jksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsrjksfgnlksjdgfbaösbgäsakngövosrfnv jöasiglakjgrblkarbfklw flhkwvbwrhntflwqruhtvwqruagvhnlsakufhvgawruohgvlunarsfhgvlarkuvhglawrkuhgjlkafhgnpvurhgerushguhguerghölevaruhsgöljsahfgvouahwrovhnralsfjhvgovyusrhgluiylrhgotvhsrtpoqhaoöhrtaörihsögföyisfhgoöysatrhvnaowrshtgvnopawurhgvauowysrhgvpuaysrhgntvoawutrhvpanrsuhgvjfftapsorztvnsr";
            char[] myCharArray = { 'a', 'b', 'ö', 'd', 'j', 'k', 's', 'h' };

            while (true)

            {
                sw.Restart();
                //Console.WriteLine($"O(n*m) = {
                findNumsOfRepetitionsV1(myString, myCharArray);
                sw.Stop();
                Console.WriteLine($"SWV1 time is: {sw.ElapsedTicks * 100 / 1000000f} ms");

                sw.Reset();
                sw.Start();
                // Console.WriteLine($"O(n+m) = {
                findNumsOfRepetitionsV2(myString, myCharArray);
                sw.Stop();
                Console.WriteLine($"SWV2 time is: {sw.ElapsedTicks * 100 / 1000000f} ms");

            }

        }
    }
}
