namespace LeetCodeSandbox._1001._2000._1901._2000._1901._1910
{
    public class Problem1909 : IProblem
    {
        public void Run()
        {
            var inputs = new List<int[]>()
            {
                new[] {1, 2, 10, 5, 7},
                new[] {2, 3, 1, 2},
                new[] {1, 1, 1},
            };
            throw new NotImplementedException();
        }
        public bool CanBeIncreasing(int[] nums)
        {
            int numOfRemoveCandidates = 0;

            if (nums.Length == 2)
                return true;

            if (nums[0] >= nums[1])
                numOfRemoveCandidates++;

            if (nums[nums.Length - 2] >= nums[nums.Length - 1])
                numOfRemoveCandidates++;

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i - 1] < nums[i] && nums[i] < nums[i + 1])
                    continue;
                //otherwise there is problem with order in this sequence
                //1 3 10 6:
                //1 3 10 ok
                //3 10 6 not ok, 3 < 6 => remove 10
                //but then 10 > 6 so we count

                //
                if (nums[i-1] < nums[i + 1])
                    numOfRemoveCandidates++;
                else
                    return false;
            }

            return numOfRemoveCandidates <= 1;
        }
    }
}
