namespace LeetCodeSandbox._1001._2000._1601._1700._1611._1620
{
    public class Problem1614 : IProblem
    {
        public void Run()
        {
            var inputs = new List<string>()
            {
                "",
                "C",
                "()()",
                "()(()())",
                "(1+(2*3)+((8)/4))+1",
                "(1)+((2))+(((3)))",
            };

            foreach (var input in inputs)
            {
                Console.WriteLine($"{input}: {MaxDepth(input)}");
            }
        }

        public int MaxDepth(string s)
        {
            int max = 0;
            int current = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    current++;
                    if (max < current)
                    {
                        max = current;
                    }
                }
                else if (s[i] == ')')
                {
                    current--;
                }
            }

            return max;
        }
    }
}
