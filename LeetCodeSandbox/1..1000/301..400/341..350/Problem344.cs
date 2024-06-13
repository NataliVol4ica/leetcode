namespace LeetCodeSandbox._1._1000._301._400._341._350
{
    public class Problem344 : IProblem
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void ReverseString(char[] s)
        {
            char temp;
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}
