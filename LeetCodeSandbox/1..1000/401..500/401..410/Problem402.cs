namespace LeetCodeSandbox._1._1000._401._500._401._410
{
    public class Problem402 : IProblem
    {
        record Input(string Num, int K);

        public void Run()
        {
            var inputs = new List<Input>
            {
                new ("1432219", 3),
                new ("1432219", 4),
                new ("1432219", 5),
                new ("1432219", 7),
                new ("10200", 1),
                new ("10", 1),
                new ("10", 2),
                new ("1000000", 1),
                new ("1000000", 2),
            };

            foreach (var input in inputs)
            {
                Console.WriteLine($"\"{input.Num}\", {input.K} : \"{RemoveKdigits(input.Num, input.K)}\"");
            }
        }

        public string RemoveKdigits(string num, int k)
        {
            if (k == num.Length || num.Length == 1)
                return "0";

            var answer = new Stack<char>();
            answer.Push(num[0]);

            for (int digitId = 1; digitId < num.Length; digitId++)
            {
                while (k > 0 && answer.TryPeek(out char peek) && peek > num[digitId])
                {
                    answer.Pop();
                    k--;
                }
                answer.Push(num[digitId]);
            }

            while (k > 0)
            {
                answer.Pop();
                k--;
            }

            var result = new string(answer.Select(a=>a).Reverse().ToArray());

            int zeroId = 0;
            
            while (zeroId < result.Length && result[zeroId] == '0')
            {
                zeroId++;
            }

            if (zeroId == result.Length)
                return "0";

            return result.Substring(zeroId);
        }
    }
}
