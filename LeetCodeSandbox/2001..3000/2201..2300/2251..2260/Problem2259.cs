namespace LeetCodeSandbox._2001._3000._2201._2300._2251._2260
{
    public class Problem2259 : IProblem
    {
        public void Run()
        {
            Console.WriteLine(RemoveDigit("123", '3'));
            Console.WriteLine(RemoveDigit("1231", '1'));
            Console.WriteLine(RemoveDigit("551", '5'));
            Console.WriteLine(RemoveDigit("133235", '3'));
        }

        public string RemoveDigit(string number, char digit)
        {
            int pos = -1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != digit)
                    continue;
                if (i == number.Length - 1)
                {
                    pos = i;
                    break;
                }
                if (number[i + 1] > number[i])
                {
                    pos = i;
                    break;
                }
            }

            if (pos == -1)
            {
                pos = number.LastIndexOf(digit);
            }

            var a = number.Substring(0, pos);
            var b = number.Substring(pos + 1);
            return a + b;
        }
    }
}
