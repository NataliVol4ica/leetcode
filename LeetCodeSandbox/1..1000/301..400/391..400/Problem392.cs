namespace LeetCodeSandbox._1._1000._301._400._391._400
{
    public class Problem392 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(IsSubsequence("abc", "ahbgdc"));
            Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
        }

        public bool IsSubsequence(string s, string t)
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
                {
                    tId++;
                }
            }

            return sId == s.Length;
        }
    }
}
