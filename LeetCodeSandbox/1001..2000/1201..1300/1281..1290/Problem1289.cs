namespace LeetCodeSandbox._1001._2000._1201._1300._1281._1290
{
    public class Problem1289 : IProblem
    {
        public void Run()
        {
            //5
            var input1 = new int[][]
            {
                new int[] { 1, 2, 3, },
                new int[] { 1, 9, 9, },
                new int[] { 7, 2, 3, },
            };

            //13
            var input2 = new int[][]
            {
                new int[] { 1, 2, 3, },
                new int[] { 4, 5, 6, },
                new int[] { 7, 8, 9, },
            };

            //-192
            var input3 = new int[][]
            {
                new int[] { -73,  61,  43, -48, -36 }, // -73, -48
                new int[] {  3,   30,  27,  57,  10 }, // -45,  -43,  -46, -16,  -63  | -45, -63  
                new int[] {  96, -76,  84,  59, -15 }, //  33,  -139,  21, -4,   -60  | -139, -60
                new int[] {  5,  -49,  76,  31,  -7 }, // -134, -109, -63, -108, -146 | -146, -134
                new int[] {  97,  91,  61, -46,  67 }, // -49,  -55,   85, -192 , -67 | -192, -67
            };

            Console.WriteLine(MinFallingPathSum(input1));
            Console.WriteLine(MinFallingPathSum(input2));
            Console.WriteLine(MinFallingPathSum(input3));
        }

        public int MinFallingPathSum(int[][] grid)
        {
            if (grid.Length == 1)
                return grid[0][0];

            int smallestId = 0;
            int secondSmallestId = 1;
            for (int j = 0; j < grid.Length; j++)
            {
                if (grid[0][j] < grid[0][smallestId])
                {
                    secondSmallestId = smallestId;
                    smallestId = j;
                }
                else if (grid[0][j] < grid[0][secondSmallestId] && j != smallestId)
                {
                    secondSmallestId = j;
                }
            }

            for (int i = 1; i < grid.Length; i++)
            {
                int newSmallestId = 0;
                int newSecondSmallestId = 1;

                for (int j = 0; j < grid.Length; j++)
                {
                    if (j != smallestId)
                    {
                        grid[i][j] += grid[i-1][smallestId];
                    }
                    else
                    {
                        grid[i][j] +=grid[i-1][secondSmallestId];
                    }

                    if (grid[i][j] < grid[i][newSmallestId])
                    {
                        newSecondSmallestId = newSmallestId;
                        newSmallestId = j;
                    }
                    else if (grid[i][j] < grid[i][newSecondSmallestId] && j != newSmallestId)
                    {
                        newSecondSmallestId = j;
                    }
                }

                smallestId = newSmallestId;
                secondSmallestId = newSecondSmallestId;
            }

            return grid[grid.Length-1][smallestId];
        }
    }
}
