namespace LeetCodeSandbox._1._1000._1._100._81._90
{
    public class Problem85 : IProblem
    {
        public void Run()
        {
            var input = new char[][]
            {
                new[] {'1', '0', '1', '0', '0'},
                new[] {'1', '0', '1', '1', '1'},
                new[] {'1', '1', '1', '1', '1'},
                new[] {'1', '0', '0', '1', '0'}
            };
            Console.WriteLine(MaximalRectangle(input));
            Console.WriteLine(MaximalRectangle(new char[][]{new []{'0'}}));
            Console.WriteLine(MaximalRectangle(new char[][]{new []{'1' } }));
        }

        public int MaximalRectangle(char[][] matrix)
        {
            int[,] closestOnes = new int[matrix.Length, matrix[0].Length];
            int max = 0;
            
            // Set horizontal closest
            for (int i = 0; i < matrix.Length; i++)
            {
                int closest = 0;
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == '0')
                        closest = 0;
                    else
                        closest++;
                    closestOnes[i,j] = closest;
                }
            }

            for (int j = 0; j < matrix[0].Length; j++)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    int min = closestOnes[i,j];
                    for (int k = i; k >= 0; k--)
                    {
                        min = Math.Min(min, closestOnes[k, j]);
                        max = Math.Max(max, min * (i - k + 1));
                    }
                }
            }

            return max;
        }
    }
}
