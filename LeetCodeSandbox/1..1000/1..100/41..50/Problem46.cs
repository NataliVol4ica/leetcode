namespace LeetCodeSandbox._1._1000._1._100._41._50
{
    public class Problem46 : IProblem
    {
        public void Run()
        {
            var result = Permute(new int[] { 1, 2, 3 });
            foreach(var list in result)
            {
                Console.WriteLine(Tools.Print(list));
            }
        }

        public List<List<int>> Permute(int[] nums)
        {
            bool[] included = new bool[nums.Length];
            List<List<int>> result = new();
            Stack<int> items = new();

            dfs();

            void dfs()
            {
                if (items.Count == nums.Length)
                {
                    result.Add(items.ToList());
                    return;
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (included[i])
                        continue;
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
