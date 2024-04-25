namespace LeetCodeSandbox._1001._2000._1101._1200._1131._1140
{
    public class Problem1137 : IProblem
    {
        public void Run()
        {
            var inputs = new int[] { 4, 25, 7 };
            foreach(var input in inputs)
            {
                Console.WriteLine($"{input} : {Tribonacci(input)}");
            }
        }

        public int Tribonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;

            int a = 0, b = 1, c = 1;
            int sum;
            n -= 2;
            while (n > 0)
            {
                n--;
                sum = a + b + c;
                a = b;
                b = c;
                c = sum;
            }
            return c;
        }
    }
}
