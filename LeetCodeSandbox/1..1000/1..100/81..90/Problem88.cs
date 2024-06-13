namespace LeetCodeSandbox._1._1000._1._100._81._90
{
    public class Problem88 : IProblem
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int resultId = nums1.Length - 1;
            int i = m - 1;
            int j = n - 1;

            while (resultId >= 0)
            {
                if (i >= 0 && j >= 0)
                {
                    if (nums1[i] > nums2[j])
                    {
                        nums1[resultId] = nums1[i];
                        i--;
                    }
                    else
                    {
                        nums1[resultId] = nums2[j];
                        j--;
                    }
                }
                else
                {
                    if (i < 0)
                    {
                        nums1[resultId] = nums2[j];
                        j--;
                    }
                    else
                    {
                        nums1[resultId] = nums1[i];
                        i--;
                    }
                }
                resultId--;
            }
        }
    }
}
