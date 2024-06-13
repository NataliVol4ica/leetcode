namespace LeetCodeSandbox._1._1000._901._1000._971._980
{
    public class Problem974 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(SubarraysDivByK(new int[] { 4, 5, 0, -2, -3, 1, }, 5));
        }
        // sum up all elements
        // take mod k
        // if sum[i] == sum[j], i!=j, it means between i and j there is a subarray whose sum is divisible by k
        // count all such matches using hashmap (dictionary)
        // include 0 as a starting point, so that [5] => {0, 5} returns 1

        //Example:
        //4,5,0,-2,-3,1
        //0, 4, 9, 9, 7, 4, 5 sum array
        //0, 4, 4, 4, 2, 4, 0 mod array
        // there are four '4' and 2 '0'
        // assuming there are N x 'number', result will be (N-1)!
        // so for '4': 1 + 2 + 3, and for '0': 1
        // total is 7

        public int SubarraysDivByK(int[] nums, int k)
        {
            Dictionary<int, int> encounters = new();
            encounters[0] = 1;
            int sum = 0;
            int total = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                sum = MyMod(sum + nums[i], k);

                if (encounters.TryGetValue(sum, out var sumEncounters))
                {
                    total += sumEncounters;
                    encounters[sum]++;
                }
                else
                {
                    encounters[sum] = 1;
                }
            }
            return total;
        }

        private int MyMod (int num, int k)
        {
            var result = num % k;
            if (result < 0)
                return result + k;
            return result;
        }
    }
}
