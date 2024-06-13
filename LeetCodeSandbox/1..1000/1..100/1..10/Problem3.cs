namespace LeetCodeSandbox._1._1000._1._100._1._10
{
    public class Problem3 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }

        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> encounters = new();
            int maxLength = 0;

            int startId = 0;
            int endId;
            for (endId = 0; endId < s.Length; endId++)
            {
                if (!encounters.ContainsKey(s[endId]))
                    encounters[s[endId]] = 0;

                encounters[s[endId]]++;

                while (encounters[s[endId]] > 1) // repeating character encountered
                {
                    encounters[s[startId++]]--;
                }

                maxLength = Math.Max(endId - startId + 1, maxLength);
            }

            return maxLength;
        }
    }
}
