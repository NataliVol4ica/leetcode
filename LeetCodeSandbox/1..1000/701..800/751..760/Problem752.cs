namespace LeetCodeSandbox._1._1000._701._800._751._760
{
    public class Problem752 : IProblem
    {
        public void Run()
        {
            var input1 = new string[] {"0201", "0101", "0102", "1212", "2002"};
            var input2 = new string[] {"8888" };
            var input3 = new string[] {"8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888"};

                Console.WriteLine(OpenLock(input1, "0202"));
                Console.WriteLine(OpenLock(input2, "0009"));
                Console.WriteLine(OpenLock(input3, "8888"));
        }

        public int OpenLock(string[] deadends, string target)
        {
            if (deadends.Contains("0000"))
                return -1;

            var queue = new Queue<(List<char> code, int steps)>();
            var visited = new HashSet<string>();

            foreach (string item in deadends)
            {
                visited.Add(item);
            }

            queue.Enqueue((new List<char> { '0', '0', '0', '0' }, 0));
            visited.Add("0000");

            while (queue.Count > 0)
            {
                var (current, steps) = queue.Dequeue();

                if (string.Join("", current) == target) 
                    return steps;

                foreach (var code in GetNeighbors(current))
                {
                    if (visited.Contains(string.Join("", code))) continue;
                    visited.Add(string.Join("", code));
                    queue.Enqueue((code, steps + 1));
                }
            }

            return -1;
        }

        private List<List<char>> GetNeighbors(List<char> code)
        {
            var neighbors = new List<List<char>>(8);
            
            for (int i = 0; i < 4; i++)
            {
                var digit = code[i] - '0';

                neighbors.Add(new List<char>(code)
                {
                    [i] = (char)((digit + 1) % 10 + '0')
                });

                neighbors.Add(new List<char>(code)
                {
                    [i] = (char)((digit + 9) % 10 + '0')
                });
            }

            return neighbors;
        }
    }

}
