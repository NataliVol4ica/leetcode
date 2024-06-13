namespace LeetCodeSandbox._1._1000._1._100._51._60
{
    public class Problem53 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
            Console.WriteLine(MaxSubArray(new int[] { 1 }));
            Console.WriteLine(MaxSubArray(new int[] { 5, 4, -1, 7, 8 }));
        }

        public int MaxSubArray(int[] nums)
        {
            int max = -10000;
            int localMax = -10000;

            for (int i = 0; i < nums.Length; i++)
            {
                localMax = Math.Max(nums[i], nums[i] + localMax);
                max = Math.Max(localMax, max);
            }

            return max;
        }
    }
}
