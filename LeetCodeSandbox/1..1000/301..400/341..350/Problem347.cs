namespace LeetCodeSandbox._1._1000._301._400._341._350
{
    public class Problem347 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(Tools.Print(TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2)));
            Console.WriteLine(Tools.Print(TopKFrequent(new int[] { 1 }, 1)));
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> encounters = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (encounters.ContainsKey(nums[i]))
                    encounters[nums[i]]++;
                else
                    encounters[nums[i]] = 1;
            }

            var result = encounters
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Take(k)
                .ToArray();

            return result;
        }
    }
}
