namespace LeetCodeSandbox._1._1000._1._100._41._50
{
    public class Problem47 : IProblem
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Stack<int> items = new();
            var result = new List<IList<int>>();
            bool[] included = new bool[nums.Length];

            dfs();

            void dfs()
            {
                if (items.Count == nums.Length)
                {
                    result.Add(items.ToList());
                    return;
                }

                HashSet<int> triedInPos = new();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (included[i])
                        continue;
                    if (triedInPos.Contains(nums[i])) // Check if this value was already checked for this pos
                        continue;
                    triedInPos.Add(nums[i]);
                    included[i] = true;
                    items.Push(nums[i]);
                    dfs();
                    items.Pop();
                    included[i] = false;
                }
            }

            return result;
        }
    }
}
