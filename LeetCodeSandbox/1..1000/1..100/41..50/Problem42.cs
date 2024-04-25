namespace LeetCodeSandbox._1._1000._1._100._41._50
{
    public class Problem42 : IProblem
    {
        public void Run()
        {
            var inputs = new List<int[]>
            {
                new []{0,1,0,2,1,0,1,3,2,1,2,1},
                new []{4,2,0,3,2,5},
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(Tools.Print(input) + ": " + Trap(input));
            }
        }
        public int Trap(int[] height)
        {
            var leftExtremums = new int[height.Length];
            int leftMax = -1;
            for (int i = 0; i < height.Length; i++)
            {
                leftMax = Math.Max(leftMax, height[i]);
                leftExtremums[i] = leftMax;
            }

            var rightExtremums = new int[height.Length];
            int rightMax = -1;
            for (int i = height.Length - 1; i >= 0; i--)
            {
                rightMax = Math.Max(rightMax, height[i]);
                rightExtremums[i] = rightMax;
            }

            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                result += Math.Min(leftExtremums[i], rightExtremums[i]) - height[i];
            }
            return result;
        }
    }
}
