using System.Numerics;

namespace LeetCodeSandbox._2001._3000._2301._2400._2361._2370
{
    public class Problem2370 : IProblem
    {
        public void Run()
        {
            var input1 = "acfgbd";
            var input2 = "abcd";

            Console.WriteLine($"'{input1}': {LongestIdealString(input1, 2)}");
            Console.WriteLine($"'{input2}': {LongestIdealString(input2, 3)}");

        }
        public int LongestIdealString(string s, int k)
        {
            var characters = new int[26];
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int current = s[i] - 'a';
                int max = 0;
                for (int previous = 0; previous < 26; previous++)
                {
                    if (Math.Abs(previous - current) <= k)
                    {
                        max = Math.Max(max, characters[previous]);
                    }
                }

                characters[current] = Math.Max(characters[current], max + 1);
                result = Math.Max(result, characters[current]);
            }
            return result;
        }
    }
}
