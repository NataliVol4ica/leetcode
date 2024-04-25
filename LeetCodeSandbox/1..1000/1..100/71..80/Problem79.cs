
namespace LeetCodeSandbox._1._1000._1._100._71._80
{
    public class Problem79 : IProblem
    {
        record Coord(int X, int Y);

        public void Run()
        {
            var sample = new char[][]
            {
                new char[] {'A', 'B', 'C', 'E'},
                new char[] {'S', 'F', 'C', 'S'},
                new char[] {'A', 'D', 'E', 'E'}
            };
            var word1 = "ABCCED";
            var word2 = "SEE";
            var word3 = "ABCB";

            Console.WriteLine(Exist(sample, word3));
        }

        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (Search(board, word, i, j, new List<Coord>(), 0))
                        return true;
                }
            }

            return false;
        }

        private bool Search(char[][] board, string word, int posX, int posY, List<Coord> existingCoords, int wordPtr)
        {
            int wordLength = word.Length;

            if (board[posX][posY] != word[wordPtr])
                return false;

            if (existingCoords.Any(c => c.X == posX && c.Y == posY))
                return false;

            existingCoords.Add(new Coord(posX, posY));
            wordPtr++;

            if (wordPtr >= wordLength)
                return true;

            if (posX + 1 < board.Length)
            {
                if (Search(board, word, posX + 1, posY, existingCoords, wordPtr))
                    return true;
            }

            if (posX - 1 >= 0)
            {
                if (Search(board, word, posX - 1, posY, existingCoords, wordPtr))
                    return true;
            }

            if (posY + 1 < board[0].Length)
            {
                if (Search(board, word, posX, posY + 1, existingCoords, wordPtr))
                    return true;
            }

            if (posY - 1 >= 0)
            {
                if (Search(board, word, posX, posY - 1, existingCoords, wordPtr))
                    return true;
            }

            existingCoords.RemoveRange(existingCoords.Count - 1, 1);

            return false;
        }
    }
}
