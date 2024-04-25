namespace LeetCodeSandbox._1._1000._601._700._671._680
{
    public class Problem678 : IProblem
    {
        public void Run()
        {
            var items = new List<string>
            {
                "()",
                "(*)",
                "(*))",
                "((*))())**))**))",
            };

            foreach (var item in items)
            {
                Console.WriteLine($"'{item}': {CheckValidString(item)}");   
            }
        }

        public bool CheckValidString(string s)
        {
            int leftMin = 0;
            int leftMax = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    leftMin++;
                    leftMax++;
                }
                else if (c == ')')
                {
                    leftMin--;
                    leftMax--;
                }
                else
                {
                    leftMin--;
                    leftMax++;
                }
                if (leftMax < 0)
                {
                    return false;
                }
                if (leftMin < 0)
                {
                    leftMin = 0;
                }
            }

            return leftMin == 0;
        }
    }
}
