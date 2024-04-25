namespace LeetCodeSandbox._1._1000._101._200._191._200
{
    public class Problem200 : IProblem
    {
        public void Run()
        {
            var input1 = new char[][]
            {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'},
            };

            var input2 = new char[][]
            {
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '1', '0', '0'},
                new char[] {'0', '0', '0', '1', '1'},
            };

            var input3 = new char[][]
            {
                new char[] {'1', '1', '1', '1', '1'},
                new char[] {'1', '0', '0', '0', '0'},
                new char[] {'1', '0', '1', '1', '1'},
                new char[] {'1', '0', '0', '0', '1'},
                new char[] {'1', '1', '1', '1', '1'},
            };

            Console.WriteLine(NumIslands(input1));
            Console.WriteLine(NumIslands(input2));
            Console.WriteLine(NumIslands(input3));
        }

        struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x; 
                Y = y;
            }

            public override string ToString()
            {
                return $"{X},{Y}";
            }
        }

        public int NumIslands(char[][] grid)
        {
            bool[,] visited = new bool[grid.Length, grid[0].Length];

            int result = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '0')
                        continue;
                    if (visited[i,j])
                        continue;

                    visited[i, j] = true;
                    var queue = new Queue<Point>();
                    queue.Enqueue(new Point(i, j));
                    while (queue.Count > 0)
                    {
                        var current = queue.Dequeue();
                        if (current.X > 0 && grid[current.X - 1][current.Y] != '0' && !visited[current.X - 1, current.Y])
                        {
                            queue.Enqueue(new Point(current.X - 1, current.Y));
                            visited[current.X - 1, current.Y] = true;
                        }
                        if (current.X < grid.Length-1 && grid[current.X + 1][current.Y] != '0' && !visited[current.X + 1, current.Y])
                        {
                            queue.Enqueue(new Point(current.X + 1, current.Y));
                            visited[current.X + 1, current.Y] = true;
                        }
                        if (current.Y > 0 && grid[current.X][current.Y - 1] != '0' && !visited[current.X, current.Y - 1])
                        {
                            queue.Enqueue(new Point(current.X, current.Y - 1));
                            visited[current.X, current.Y - 1] = true;
                        }
                        if (current.Y < grid[0].Length-1 && grid[current.X][current.Y + 1] != '0' && !visited[current.X, current.Y + 1])
                        {
                            queue.Enqueue(new Point(current.X, current.Y + 1));
                            visited[current.X, current.Y + 1] = true;
                        }
                    }

                    result++;
                }
            }

            return result;
        }
    }
}
