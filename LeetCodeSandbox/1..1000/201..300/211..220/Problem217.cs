namespace LeetCodeSandbox._1._1000._201._300._211._220
{
    public class Problem217 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
        }

        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> map = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    return true;
                map[nums[i]] = 1;
            }
            return false;
        }
    }
}
