namespace LeetCodeSandbox._1._1000._201._300._231._240
{
    public class Problem238 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(Tools.Print(ProductExceptSelf(new int[] { 1, 2, 3, 4 })));
            Console.WriteLine(Tools.Print(ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 })));
        }

        public int[] ProductExceptSelf(int[] nums)
        {
            int totalMul = 1;
            int zeroId = -1;
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (zeroId >= 0)
                        return result;
                    else
                        zeroId = i;
                }
                else
                    totalMul *= nums[i];
            }

            if (zeroId >= 0)
            {
                result[zeroId] = totalMul;
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = totalMul / nums[i];
            }

            return result;
        }
    }
}
