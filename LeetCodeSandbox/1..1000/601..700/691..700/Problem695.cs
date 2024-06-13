namespace LeetCodeSandbox._1._1000._601._700._691._700
{
    public class Problem695 : IProblem
    {
        public void Run()
        {
            var grid = new int[][] {
                new int[] {0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0} };

            Console.WriteLine(MaxAreaOfIsland(grid));
        }

        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public int MaxAreaOfIsland(int[][] grid)
        {
            int h = grid.Length;
            int w = grid[0].Length;
            bool[][] visited = grid.Select(row => Enumerable.Repeat(false, w).ToArray()).ToArray();

            int maxArea = 0;

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (visited[i][j])
                        continue;

                    visited[i][j] = true;

                    if (grid[i][j] == 1)
                    {
                        int islandArea = 0;
                        Queue<Point> queue = new();
                        queue.Enqueue(new Point(i, j));

                        Action<int, int> CheckNeighbor = (int x, int y) => {
                            if (x >= 0 && x < h &&
                                y >= 0 && y < w &&
                                !visited[x][y])
                            {
                                visited[x][y] = true;
                                if (grid[x][y] == 1)
                                {
                                    queue.Enqueue(new Point(x, y));
                                }
                            }
                        };

                        while (queue.Count > 0)
                        {
                            var current = queue.Dequeue();
                            islandArea++;
                            CheckNeighbor(current.X - 1, current.Y);
                            CheckNeighbor(current.X + 1, current.Y);
                            CheckNeighbor(current.X, current.Y - 1);
                            CheckNeighbor(current.X, current.Y + 1);
                        }

                        maxArea = Math.Max(maxArea, islandArea);
                    }
                }
            }

            return maxArea;
        }
    }
}
