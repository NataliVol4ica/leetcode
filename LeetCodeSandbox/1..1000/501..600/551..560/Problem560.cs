namespace LeetCodeSandbox._1._1000._501._600._551._560
{
    public class Problem560 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(SubarraySum(new int[] { 1, 2, 3 }, 3));
        }

        // See 523 or 974
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> encounters = new();
            encounters[0] = 1;
            int sum = 0;
            int result = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                sum += nums[i];
                int numToLookup = sum - k;

                if (encounters.TryGetValue(numToLookup, out var encountersSum))
                {
                    result += encountersSum;
                }

                if (!encounters.ContainsKey(sum))
                {
                    encounters[sum] = 1;
                }
                else
                {
                    encounters[sum]++;
                }
            }

            return result;
        }
    }
}
