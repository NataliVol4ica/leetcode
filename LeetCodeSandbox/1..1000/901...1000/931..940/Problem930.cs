using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandbox._1._1000._901._1000._931._940
{
    public class Problem930 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(NumSubarraysWithSum2(new int[] { 1, 0, 1, 0, 1 }, 2));
            Console.WriteLine(NumSubarraysWithSum2(new int[] { 0, 0, 0, 0, 0 }, 0));
        }

        // See 523
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            Dictionary<int, int> encounters = new();
            encounters[0] = 1;
            int total = 0;
            int sum = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                sum += nums[i];
                if (encounters.TryGetValue(sum - goal, out var sumEncounters))
                    total+= sumEncounters;

                if (encounters.ContainsKey(sum))
                    encounters[sum]++;
                else
                    encounters[sum] = 1;
            }

            return total;
        }

        // Sliding window
        public int NumSubarraysWithSum2(int[] nums, int goal)
        {
            //todo
            return -1;
        }
    }
}
