namespace LeetCodeSandbox._1._1000._1._100._51._60
{
    public class Problem58 : IProblem
    {
        public void Run()
        {
            string input = "  Length Of  Last Word   ";
            Console.WriteLine(input + ": " + LengthOfLastWord(input));
        }
        public int LengthOfLastWord(string s)
        {
            return s.Trim().Split().LastOrDefault()?.Length ?? 0;
        }
    }
}
