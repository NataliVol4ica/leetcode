namespace LeetCodeSandbox._1001._2000._1001._1100._1051._1060
{
    public class Problem1051 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 }));
            Console.WriteLine(HeightChecker(new int[] { 5, 1, 2, 3, 4 }));
            Console.WriteLine(HeightChecker(new int[] { 1, 2, 3, 4, 5 }));
        }

        public int HeightChecker(int[] heights)
        {
            int total = 0;

            var expected = heights.OrderBy(i => i).ToList();

            for (int i = 0; i < heights.Length; i++)
            {
                total += expected[i] != heights[i] ? 1 : 0;
            }

            return total;
        }
    }
}
