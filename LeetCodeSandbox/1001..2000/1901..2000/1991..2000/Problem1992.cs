namespace LeetCodeSandbox._1001._2000._1901._2000._1991._2000
{
    public class Problem1992 : IProblem
    {
        public void Run()
        {
            var input1 = new int[][]
            {
                new int[] { 1, 0, 0 },
                new int[] { 0, 1, 1 },
                new int[] { 0, 1, 1 }
            };
            var input2 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 1, 1 }
            };
            var input3 = new int[][]
            {
                new int[] { 0 },
            };

            Console.WriteLine(AnsString(FindFarmland(input1)));
            Console.WriteLine(AnsString(FindFarmland(input2)));
            Console.WriteLine(AnsString(FindFarmland(input3)));
        }

        string AnsString(int[][] input)
        {
            var stringList = input.Select(items => $"[{string.Join(",", items.Select(i => i.ToString()))}]");
            return $"[{string.Join(",", stringList)}]";
        }

        public int[][] FindFarmland(int[][] land)
        {
            List<int[]> result = new List<int[]>();

            for (int i = 0; i < land.Length; i++)
            {
                for (int j = 0; j < land[i].Length; j++)
                {
                    if (land[i][j] == 0)
                        continue;

                    int[] newLand = new int[4];
                    newLand[0] = i;
                    newLand[1] = j;

                    int landI = i;
                    int landJ = j;

                    while (landI < land.Length - 1 && land[landI + 1][j] == 1)
                    {
                        landI++;
                    }

                    while (landJ < land[0].Length - 1 && land[i][landJ + 1] == 1)
                    {
                        landJ++;
                    }

                    newLand[2] = landI;
                    newLand[3] = landJ;

                    result.Add(newLand);

                    for (int m = i; m <= landI; m++)
                    {
                        for (int n = j; n <= landJ; n++)
                        {
                            land[m][n] = 0;
                        }
                    }
                }
            }
            return result.ToArray();
        }
    }
}
