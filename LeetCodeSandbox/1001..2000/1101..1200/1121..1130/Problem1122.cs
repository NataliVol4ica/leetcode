namespace LeetCodeSandbox._1001._2000._1101._1200._1121._1130
{
    public class Problem1122 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(Tools.Print(RelativeSortArray(
                new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 }, 
                new int[] { 2, 1, 4, 3, 9, 6 }
                )));
        }

        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> numberPositions = new();
            for (int i = 0; i < arr2.Length; i++)
            {
                numberPositions[arr2[i]] = i;
            }
            Dictionary<int, int> arr1Quantities = new();
            Dictionary<int, int> extrasQuantities = new();
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1Quantities.ContainsKey(arr1[i]))
                    arr1Quantities[arr1[i]]++;
                else if (numberPositions.ContainsKey(arr1[i]))
                    arr1Quantities[arr1[i]] = 1;
                else
                {
                    if (extrasQuantities.ContainsKey(arr1[i]))
                        extrasQuantities[arr1[i]]++;
                    else
                        extrasQuantities[arr1[i]] = 1;
                }
            }

            var result = numberPositions
                .SelectMany(n => Enumerable.Repeat(n.Key, arr1Quantities[n.Key]))
                .Concat(
                    extrasQuantities
                        .OrderBy(n => n.Key)
                        .SelectMany(n => Enumerable.Repeat(n.Key, n.Value))
                )
                .ToArray();
            return result;
        }
    }
}
