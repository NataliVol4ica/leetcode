using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSandbox._1._1000._1._100._1._10
{
    public class Problem4 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
            Console.WriteLine(FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 4 }));
            Console.WriteLine(FindMedianSortedArrays(new int[] { }, new int[] { 1 }));
            Console.WriteLine(FindMedianSortedArrays(new int[] { }, new int[] { 1, 2, 3, 4 }));
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int ptr1 = 0;
            int ptr2 = 0;
            int total = 0;

            bool include2Numbers = (nums2.Length + nums1.Length) % 2 == 0;
            int stop = (nums1.Length + nums2.Length / 2) - 1;

            while (ptr1 < nums1.Length && ptr2 < nums2.Length && total < stop)
            {
                if (nums1[ptr1] > nums2[ptr2])
                    ptr2++;
                else
                    ptr1++;

                total++;
            }

            while (total < stop)
            {
                if (ptr1 == nums1.Length)
                    ptr2++;
                else
                    ptr1++;
                total++;
            }

            if (!include2Numbers)
            {
                if (ptr1 == nums1.Length)
                    return nums2[ptr2];
                if (ptr2 == nums2.Length)
                    return nums1[ptr1];

                return Math.Min(nums1[ptr1], nums2[ptr2]);
            }

            int num1 = ptr1 == nums1.Length || (ptr2 < nums2.Length && nums1[ptr1] > nums2[ptr2]) ? nums2[ptr2++] : nums1[ptr1++];
            int num2 = ptr1 == nums1.Length || (ptr2 < nums2.Length && nums1[ptr1] > nums2[ptr2]) ? nums2[ptr2++] : nums1[ptr1++];

            return ((double)(num1 + num2)) / 2;
        }
    }
}
