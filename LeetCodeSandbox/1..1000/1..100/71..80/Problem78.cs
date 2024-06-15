namespace LeetCodeSandbox._1._1000._1._100._71._80
{
    public class Problem78 : IProblem
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            int numofSubsets = GetPow2(nums.Length);

            for (int i = 0; i < numofSubsets; i++)
            {
                int n = i;
                int id = 0;
                IList<int> list = new List<int>();

                while (n > 0)
                {
                    if (n % 2 == 1)
                        list.Add(nums[id]);
                    id++;
                    n /= 2;
                }
                result.Add(list);
            }

            return result;
        }

        int GetPow2(int pow)
        {
            int result = 1;
            while (pow > 0)
            {
                result *= 2;
                pow--;
            }
            return result;
        }
    }
}
