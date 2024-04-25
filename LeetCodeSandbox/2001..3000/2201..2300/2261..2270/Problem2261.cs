using System.Text;

namespace LeetCodeSandbox._2001._3000._2201._2300._2261._2270
{
    public class Problem2261 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(CountDistinct(new[] {2, 3, 3, 2, 2}, 2, 2));
            Console.WriteLine(CountDistinct(new[] {1, 2, 3, 4}, 4, 1));
        }

        public int CountDistinct(int[] nums, int k, int p)
        {
            HashSet<string> knownSubarrays = new();
            StringBuilder sb = new();
            int numOfNums = nums.Length;

            for (int i = 0; i < numOfNums; i++)
            {
                sb.Clear();
                int current = 0;
                for (int j = i; j < numOfNums; j++)
                {
                    if (nums[j] % p == 0)
                    {
                        if (current == k) break;
                        current++;
                    }
                    sb.Append(nums[j]).Append('-');
                    var key = sb.ToString();
                    knownSubarrays.Add(key);
                }
            }

            return knownSubarrays.Count;
        }
    }
}
