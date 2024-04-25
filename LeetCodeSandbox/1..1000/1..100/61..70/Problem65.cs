using System.Text.RegularExpressions;

namespace LeetCodeSandbox._1._1000._1._100
{
    public class Problem65 : IProblem
    {
        public void Run()
        {
            var valids = new List<string>{ "2", "0089", "-0.1", "+3.14", "4.", "-.9", "2e10", "-90E3", "3e+7", "+6e-1", "53.5e93", "-123.456e789" };
            var invalids = new List<string>{ "abc", "1a", "1e", "e3", "99e2.5", "--6", "-+3", "95a54e53" };

            for (int i = 0; i < valids.Count; i++)
            {
                Console.WriteLine(valids[i] +" " + IsNumber(valids[i]));
            }
            for (int i = 0; i < invalids.Count; i++)
            {
                Console.WriteLine(invalids[i] +" " + IsNumber(invalids[i]));
            }

        }

        public bool IsNumber(string s)
        {
            return Regex.IsMatch(s, @"^[+-]?([0-9]+(\.[0-9]+)?|[0-9]+\.|\.[0-9]+)([eE][+-]?[0-9]+)?$");
        }
    }
}
