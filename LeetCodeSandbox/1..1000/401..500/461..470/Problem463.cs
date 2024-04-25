namespace LeetCodeSandbox._1._1000._401._500._461._470
{
    public class Problem463 : IProblem
    {
        public void Run()
        {
            var input = new int[][]
            {
                new int[] {0, 1, 0, 0},
                new int[] {1, 1, 1, 0},
                new int[] {0, 1, 0, 0},
                new int[] {1, 1, 0, 0},
            };

            Console.WriteLine(IslandPerimeter(input));
        }

        public int IslandPerimeter(int[][] grid)
        {
            var result = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    // horizontal
                    if (j == 0)
                        result += grid[i][j];
                    if (j == grid[i].Length - 1)
                    {
                        result += grid[i][j];
                    }
                    else
                    {
                        result += grid[i][j] ^ grid[i][j + 1];
                    }

                    // vertical
                    if (i == 0)
                        result += grid[i][j];
                    if (i == grid.Length - 1)
                    {
                        result += grid[i][j];
                    }
                    else
                    {
                        result += grid[i + 1][j] ^ grid[i][j];
                    }
                }
            }

            return result;
        }
    }
}
