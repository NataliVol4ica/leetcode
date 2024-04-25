using System.Text;

namespace LeetCodeSandbox._1001._2000._1201._1300._1241._1250
{
    public class Problem1249 : IProblem
    {
        public void Run()
        {
            var items = new List<string>
            {
                "lee(t(c)o)de)",
                "a)b(c)d",
                "))((",
                ")((c)d()(l",
            };

            foreach (var item in items)
            {
                Console.WriteLine($"'{item}': '{MinRemoveToMakeValid(item)}'");
            }
        }

        public string MinRemoveToMakeValid(string s)
        {
            var bracesCount = 0;
            var bracesIds = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    bracesIds.Push(i);
                    bracesCount++;
                }
                else if (s[i] == ')')
                {
                    if (bracesCount == 0)
                    {
                        bracesIds.Push(i);
                    }
                    else
                    {
                        bracesCount--;
                        bracesIds.Pop();
                    }
                }
            }

            var builder = new StringBuilder(s);
            while (bracesIds.Count > 0)
            {
                var id = bracesIds.Pop();
                builder.Remove(id, 1);
            }

            return builder.ToString();
        }
    }
}
