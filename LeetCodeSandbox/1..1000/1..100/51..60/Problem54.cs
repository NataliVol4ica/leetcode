namespace LeetCodeSandbox._1._1000._1._100._51._60
{
    public class Problem54 : IProblem
    {
        public void Run()
        {
            var matrix = new int[][]
            {
                new int[]{1,2,3},
                new int[]{4,5,6},
                new int[]{7,8, 9},
            };
            Console.WriteLine(Tools.Print(SpiralOrder(matrix)));
        }

        // Create bool [][] of visited elements
        // Implement 4 while cycles, 1 per direction
        // Stop cycles either at the end of matrix or when next element is visited

        public List<int> SpiralOrder(int[][] matrix)
        {
            int h = matrix.Length;
            int w = matrix[0].Length;
            int sizeofResult = h * w;

            var result = new List<int>(sizeofResult);
            bool[,] visited = new bool[h, w];

            int i = 0;
            int x = 0;
            int y = 0;
            result.Add(matrix[0][0]);
            visited[0, 0] = true;
            i++;
            while (i < sizeofResult)
            {
                while (y + 1 < w && !visited[x, y + 1])
                {
                    y++;
                    i++;
                    result.Add(matrix[x][y]);
                    visited[x, y] = true;
                }
                while (x + 1 < h && !visited[x + 1, y])
                {
                    x++;
                    i++;
                    result.Add(matrix[x][y]);
                    visited[x, y] = true;
                }
                while (y - 1 >= 0 && !visited[x, y - 1])
                {
                    y--;
                    i++;
                    result.Add(matrix[x][y]);
                    visited[x, y] = true;
                }
                while (x - 1 >= 0 && !visited[x - 1, y])
                {
                    x--;
                    i++;
                    result.Add(matrix[x][y]);
                    visited[x, y] = true;
                }
            }

            return result;
        }
    }
}
