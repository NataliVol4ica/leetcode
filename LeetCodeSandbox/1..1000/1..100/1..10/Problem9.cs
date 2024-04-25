namespace LeetCodeSandbox._1._1000._1._100._1._10
{
    public class Problem9 : IProblem
    {
        public void Run()
        {
            var items = new List<int>
            {
                1,
                10,
                11,
                100,
                -5,
                121,
                1234321,
            };

            foreach (var item in items)
            {
                Console.WriteLine(item+ ": " + IsPalindrome(item));
            }
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            string num = x.ToString();
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            return num.Equals(new string(charArray));
        }
    }
}
