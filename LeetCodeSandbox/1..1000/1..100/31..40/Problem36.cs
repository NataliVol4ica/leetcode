namespace LeetCodeSandbox._1._1000._1._100._31._40
{
    public class Problem36 : IProblem
    {
        public void Run()
        {
            var sudoku = new char[][]
            {
                new char[]{'5','3','.','.','7','.','.','.','.'},
                new char[]{'6','.','.','1','9','5','.','.','.'},
                new char[]{'.','9','8','.','.','.','.','6','.'},
                new char[]{'8','.','.','.','6','.','.','.','3'},
                new char[]{'4','.','.','8','.','3','.','.','1'},
                new char[]{'7','.','.','.','2','.','.','.','6'},
                new char[]{'.','6','.','.','.','.','2','8','.'},
                new char[]{'.','.','.','4','1','9','.','.','5'},
                new char[]{'.','.','.','.','8','.','.','7','9'},
            };
            Console.WriteLine(IsValidSudoku(sudoku));
        }
        
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<char, int> temp = new();

            // Check Rows
            int w = board[0].Length;
            int h = board.Length;

            for (int i = 0; i < h; i++)
            {
                temp.Clear();
                for (int j = 0; j < w; j++)
                {
                    if (board[i][j] == '.')
                        continue;
                    if (temp.ContainsKey(board[i][j]))
                        return false;
                    temp[board[i][j]] = 1;
                }
            }

            // Check columns
            for (int j = 0; j < w; j++)
            {
                temp.Clear();
                for (int i = 0; i < h; i++)
                {
                    if (board[i][j] == '.')
                        continue;
                    if (temp.ContainsKey(board[i][j]))
                        return false;
                    temp[board[i][j]] = 1;
                }
            }

            // Check 3x3s
            for (int a = 0; a < 9; a++)
            {
                temp.Clear();
                int minI = (a / 3) * 3;
                int maxI = minI + 3;
                int minJ = (a % 3) * 3;
                int maxJ = minJ + 3;
                for (int i = minI; i < maxI; i++)
                {
                    for (int j = minJ; j < maxJ; j++)
                    {
                        if (board[i][j] == '.')
                            continue;
                        if (temp.ContainsKey(board[i][j]))
                            return false;
                        temp[board[i][j]] = 1;
                    }
                }
            }
            return true;
        }
    }
}
