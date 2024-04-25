namespace LeetCodeSandbox._2001._3000._2501._2600._2591._2600
{
    public class Problem2591 : IProblem
    {
        public void Run()
        {
            List<Tuple<int, int>> datas = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(20, 3),
                new Tuple<int, int>(16, 2),
                new Tuple<int, int>(1, 2),
                new Tuple<int, int>(2, 2),
                new Tuple<int, int>(9, 2),
                new Tuple<int, int>(12, 2),
                new Tuple<int, int>(13, 3),
                new Tuple<int, int>(24, 3),
                new Tuple<int, int>(28, 3),
                new Tuple<int, int>(7, 1),
                new Tuple<int, int>(8, 1),
                new Tuple<int, int>(9, 1),
            };


            foreach (var data in datas)
            {
                Console.WriteLine($"{data.Item1}, {data.Item2} : {DistMoney(data.Item1, data.Item2)}");
            }
        }
        public int DistMoney(int money, int children)
        {
            if (money < children)
                return -1;

            money -= children;// give 1 to everyone

            if (money == 0)
                return 0;

            int eights = money / 7;

            if (eights < 1)
                return 0;

            if (eights == children)
            {
                if (money % 7 == 0)
                {
                    return children;
                }
                else
                {
                    return eights - 1;
                }
            }

            if (eights > children)
                return children - 1;

            int leftover = money - ((int) (money / 7)) * 7;
            if (leftover == 3)
            {
                if (eights == children - 1)
                {
                    return eights - 1;
                }
                else
                {
                    return eights;
                }
            }

            return eights;
        }
    }
}
