namespace LeetCodeSandbox._1._1000._501._600._521._530
{
    public class Problem525 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(FindMaxLength(new int[] { 0, 1 }));
            Console.WriteLine(FindMaxLength(new int[] { 0, 1, 0 }));
        }

        public int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> indexes = new();
            indexes[0] = -1;

            int sum = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i] == 0 ? -1 : 1;

                if (indexes.TryGetValue(sum, out var index))
                {
                    max = Math.Max(max, i - index);
                }
                else
                {
                    indexes[sum] = i;
                }
            }

            return max;
        }
    }
}
