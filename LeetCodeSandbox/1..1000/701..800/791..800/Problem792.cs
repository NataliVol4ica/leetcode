namespace LeetCodeSandbox._1._1000._701._800._791._800
{
    public class Problem792 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(NumMatchingSubseq("abcde", new string[] { "a", "bb", "acd", "ace" }));
            Console.WriteLine(NumMatchingSubseq("dsahjpjauf", new string[] { "ahjpjau", "ja", "ahbwzgqnuk", "tnmlanowax" }));
        }

        public int NumMatchingSubseq(string s, string[] words)
        {
            return words
                .Where(w => IsSubsequence(s, w))
                .Count();
        }

        private bool IsSubsequence(string s, string word)
        {
            int wordId = 0;
            int sId = 0;
            while (wordId < word.Length && sId < s.Length)
            {
                if (word[wordId] == s[sId])
                {
                    wordId++;
                    sId++;
                }
                else
                {
                    sId++;
                }
            }
            return wordId == word.Length;
        }
    }
}
