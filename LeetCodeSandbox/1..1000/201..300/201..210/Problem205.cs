namespace LeetCodeSandbox._1._1000._201._300;

public class Problem205 : IProblem
{
    record Inputs(string S, string T);

    private readonly List<Inputs> _testCases = new()
    {
        new("egg", "add"),
        new("foo", "bar"),
        new("paper", "title"),
        new("badc", "baba"),
    };

    public void Run()
    {
        foreach (var input in _testCases)
        {
            Console.WriteLine($"{input.S}, {input.T}, {IsIsomorphic(input.S, input.T)}");
        }
    }

    public bool IsIsomorphic(string s, string t)
    {
        var replacementChars = new char[128];
        for (int i = 0; i < s.Length; i++)
        {
            if (replacementChars[s[i]] != 0 && replacementChars[s[i]] != t[i])
                return false;
            replacementChars[s[i]] = t[i];
        }

        var notNulls = replacementChars.Where(ch => ch != 0);
        if (notNulls.Count() != notNulls.Distinct().Count())
            return false;

        return true;
    }
    
}
