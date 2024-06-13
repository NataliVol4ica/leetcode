namespace LeetCodeSandbox._3001._4000._3101._3110
{
    public class Problem3110 : IProblem
    {
        public void Run()
        {
            Console.WriteLine("hello");
            Console.WriteLine("zaz");
        }

        public int ScoreOfString(string s)
        {
            int total = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                total += Math.Abs(s[i] - s[i + 1]);
            }
            return total;
        }
    }
}
