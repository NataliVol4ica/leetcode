namespace LeetCodeSandbox._1._1000._101._200._121._130
{
    public class Problem128 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));
        }

        public int LongestConsecutive(int[] nums)
        {
            var encounters = new HashSet<int>(nums);
            int max = 0;

            foreach (var encounter in encounters)
            {
                if (encounters.Contains(encounter - 1))
                    continue;

                int len = 0;
                while (encounters.Contains(encounter + len))
                {
                    len++;
                }

                max = Math.Max(max, len);

            }

            return max;
        }
    }
}
