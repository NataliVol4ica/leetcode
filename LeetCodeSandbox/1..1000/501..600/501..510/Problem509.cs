namespace LeetCodeSandbox._1._1000._501._600._501._510
{
    public class Problem509 : IProblem
    {
        public void Run()
        {
            var inputs = new int[] { 2, 3, 4, 25 };
            foreach (var input in inputs)
            {
                Console.WriteLine($"{input} : {Fib(input)}");
            }
        }

        public int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            int a = 0, b = 1;
            int sum;
            n -= 1;
            while (n > 0)
            {
                n--;
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
