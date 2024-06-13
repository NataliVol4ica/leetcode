namespace LeetCodeSandbox._2001._3000._2401._2500._2481._2490
{
    public class Problem2486 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(AppendCharacters("coaching", "coding"));
            Console.WriteLine(AppendCharacters("abcde", "a"));
            Console.WriteLine(AppendCharacters("z", "abcde"));
        }

        public int AppendCharacters(string s, string t)
        {
            int sId = 0;
            int tId = 0;

            while (sId < s.Length && tId < t.Length)
            {
                if (s[sId] == t[tId])
                {
                    sId++;
                    tId++;
                }
                else
                    sId++;
            }

            return t.Length - tId;
        }
    }
}
