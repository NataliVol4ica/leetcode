namespace LeetCodeSandbox._1._1000._201._300._201._210
{
    public class Problem209 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 }));
            Console.WriteLine(MinSubArrayLen(4, new int[] { 1, 4, 4 }));
            Console.WriteLine(MinSubArrayLen(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }));
        }

        public int MinSubArrayLen(int target, int[] nums)
        {
            int sum = nums[0];
            int len = 1;
            int minLen = 2147483647;
            int startId = 0;

            if (sum >= target)
                return 1;

            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
                len++;

                if (sum >= target)
                {
                    while (sum >= target)
                    {
                        minLen = Math.Min(minLen, len);
                        sum -= nums[startId];
                        startId++;
                        len--;
                    }
                }
            }

            if (minLen == 2147483647)
                return 0;

            return minLen;
        }
    }
}
