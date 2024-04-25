namespace LeetCodeSandbox._2001._3000._2201._2300._2261._2270
{
    public class Problem2262 : IProblem
    {
        public void Run()
        {
            var testData = new List<string>
            {
                "abbca",
                "code",
            };

            foreach (var test in testData)
            {
                Console.WriteLine(test + ": " + AppealSum(test));
            }
        }

        public long AppealSum(string s)
        {
            long result = 0;
            var lastOccurrences = Enumerable.Repeat(-1, 26).ToArray();
            
            for (int i = 0; i < s.Length; i++)
            {
                result += (i - lastOccurrences[s[i] - 'a']) * (s.Length - i);
                lastOccurrences[s[i] - 'a'] = i;
            }
            return result;
        }
    }
}
