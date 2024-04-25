using System.Runtime.ExceptionServices;

namespace LeetCodeSandbox._2001._3000._2201._2300._2251._2260
{
    public class Problem2260 : IProblem
    {
        public void Run()
        {
            var items = new List<int[]>()
            {
                new[] {3, 4, 2, 3, 4, 7},
                new[] {1, 0, 5, 3},
                new [] { 95, 11, 8, 65, 5, 86, 30, 27, 30, 73, 15, 91, 30, 7, 37, 26, 55, 76, 60, 43, 36, 85, 47, 96, 6},
                new [] {1000000},
            };

            foreach (var item in items)
            {
                Console.WriteLine(string.Join(", ", item) + "  :   " + MinimumCardPickup(item));
            }
        }
        public int MinimumCardPickup(int[] cards)
        {
            int result = Int32.MaxValue;
            Dictionary<int, int> lastIndexes = new Dictionary<int, int>();

            for (int i = 0; i < cards.Length; i++)
            {
                if (lastIndexes.TryGetValue(cards[i], out var lastIndex))
                    result = Math.Min(result, i - lastIndex + 1);
                lastIndexes[cards[i]] = i;
            }

            if (result == Int32.MaxValue)
                return -1;

            return result;
        }
    }
}
