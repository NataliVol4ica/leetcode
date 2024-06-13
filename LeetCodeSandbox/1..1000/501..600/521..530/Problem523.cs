namespace LeetCodeSandbox._1._1000._501._600._521._530
{
    public class Problem523 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(CheckSubarraySum(new[] { 23, 2, 4, 6, 7 }, 6));
            Console.WriteLine(CheckSubarraySum(new[] { 23, 2, 6, 4, 7 }, 6));
            Console.WriteLine(CheckSubarraySum(new[] { 23, 2, 6, 4, 7 }, 13));
        }
        
        // See 974
        // sum up all elements
        // take mod k
        // if sum[i] == sum[j], i!=j, it means between i and j there is a subarray whose sum is divisible by k
        // find at least one such match
        // include 0 as a starting point, so that [5] => {0, 5} returns true for 5
        // exclude neighboring results. so 1 4 4 does not fit

        public bool CheckSubarraySum(int[] nums, int k)
        {
            int modSum = 0;
            HashSet<int> encounteredMods = new();
            int previous = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                modSum = (modSum + nums[i]) % k;
                if (encounteredMods.Contains(modSum))
                    return true;
                encounteredMods.Add(previous);
                previous = modSum;
            }
            return false;
        }
    }
}
