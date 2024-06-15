namespace LeetCodeSandbox._1._1000._901._1000._941._950
{
    public class Problem945 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(MinIncrementForUnique(new int[] { 7, 2, 7, 2, 1, 4, 3, 1, 4, 8 }));
        }

        public int MinIncrementForUnique(int[] nums)
        {
            Array.Sort(nums); // O(n logn)
            int total = 0;
            int numOfDuplicates = 0;
            for (int i = 1; i < nums.Length; i++) // O(n)
            {
                if (nums[i] == nums[i - 1])
                {
                    numOfDuplicates++;
                    continue;
                }
                if (numOfDuplicates == 0)
                    continue;

                int dupsToRemove = Math.Min(nums[i] - nums[i - 1] - 1, numOfDuplicates);

                total += Sum(dupsToRemove);
                numOfDuplicates -= dupsToRemove;
                total += numOfDuplicates * dupsToRemove + numOfDuplicates;
            }
            total += Sum(numOfDuplicates);
            return total;
        }

        private int Sum(int x) => x * (x + 1) / 2;
    }
}
