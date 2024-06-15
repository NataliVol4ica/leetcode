namespace LeetCodeSandbox._1._1000._1._100._31._40
{
    public class Problem39 : IProblem
    {
        public void Run()
        {
            CombinationSum(new int[] { 2, 3, 6, 7 }, 7);
        }

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Stack<int> stack = new();
            int sum = 0;
            dfs(0);

            void dfs(int startId)
            {
                if (sum == target)
                {
                    result.Add(stack.ToList());
                    return;
                }
                if (sum > target)
                    return;

                for (int i = startId; i < candidates.Length; i++)
                {
                    sum += candidates[i];
                    stack.Push(candidates[i]);
                    dfs(i);
                    stack.Pop();
                    sum -= candidates[i];
                }
            }

            return result;
        }
    }
}
