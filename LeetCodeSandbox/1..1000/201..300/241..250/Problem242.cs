namespace LeetCodeSandbox._1._1000._201._300._241._250
{
    public class Problem242 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
            Console.WriteLine(IsAnagram("rat", "car"));
        
        }
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> encounters = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (encounters.ContainsKey(s[i]))
                    encounters[s[i]]++;
                else
                    encounters[s[i]] = 1;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!encounters.ContainsKey(t[i]))
                    return false;
                else
                    encounters[t[i]]--;
                if (encounters[t[i]] < 0)
                    return false;
            }

            return !encounters.Any(e => e.Value != 0);
        }
    }
}
