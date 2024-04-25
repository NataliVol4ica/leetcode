
namespace LeetCodeSandbox._2001._3000._2601._2700._2651._2660
{
    public class Problem2658 : IProblem
    {
        public void Run()
        {
            int[][] grid = new int[][]
            {
                new int[] {0, 2, 1, 0},
                new int[] {4, 0, 0, 3},
                new int[] {1, 0, 0, 4},
                new int[] {0, 3, 2, 0}
            };
            int[][] grid2 = new int[][]
            {
                new int[] { 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 1 }
            };

            Console.WriteLine(FindMaxFish(grid));
        }

        public int FindMaxFish(int[][] grid)
        {
            int result = 0;
            int current;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                        continue;
                    current = CountFish(grid, i, j);
                    if (result < current)
                        result = current;
                }
            }

            return result;
        }

        private record Coord(int X, int Y);

        private int CountFish(int[][] grid, int i, int j)
        {
            int result = grid[i][j];
            grid[i][j] = 0;
            Stack<Coord> coordStack = new Stack<Coord>();
            coordStack.Push(new Coord(i, j));

            while (coordStack.Count > 0)
            {
                var current = coordStack.Pop();
                if (current.X - 1 >= 0 && grid[current.X - 1][current.Y] != 0)
                {
                    result += grid[current.X - 1][current.Y];
                    grid[current.X - 1][current.Y] = 0;
                    coordStack.Push(new Coord(current.X - 1, current.Y));
                }

                if (current.X + 1 < grid.Length && grid[current.X + 1][current.Y] != 0)
                {
                    result += grid[current.X + 1][current.Y];
                    grid[current.X + 1][current.Y] = 0;
                    coordStack.Push(new Coord(current.X + 1, current.Y));
                }

                if (current.Y - 1 >= 0 && grid[current.X][current.Y - 1] != 0)
                {
                    result += grid[current.X][current.Y - 1];
                    grid[current.X][current.Y - 1] = 0;
                    coordStack.Push(new Coord(current.X, current.Y - 1));
                }

                if (current.Y + 1 < grid[0].Length && grid[current.X][current.Y + 1] != 0)
                {
                    result += grid[current.X][current.Y + 1];
                    grid[current.X][current.Y + 1] = 0;
                    coordStack.Push(new Coord(current.X, current.Y + 1));
                }
            }

            return result;
        }
    }
}
