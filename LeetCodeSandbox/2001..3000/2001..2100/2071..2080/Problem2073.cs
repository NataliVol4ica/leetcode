namespace LeetCodeSandbox._2001._3000._2001._2100._2071._2080
{
    public class Problem2073 : IProblem
    {
        record Input(int[] Tickets, int K);

        public void Run()
        {
            var inputs = new List<Input>
            {
                new Input(new[] {2, 3, 2}, 2),
                new Input(new[] {5, 1, 1, 1}, 0),
            };

            for (int i = 0; i < inputs.Count; i++)
            {
                Console.WriteLine($"[{string.Join(",", inputs[i].Tickets)}] k={inputs[i].K}: {TimeRequiredToBuy(inputs[i].Tickets, inputs[i].K)}");
            }
        }

        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int kPerson = tickets[k];
            int kPersonMinusOne = kPerson - 1;
            int total = 0;

            for (int i = 0; i < tickets.Length; i++)
            {
                if (i <= k)
                {
                    total += Math.Min(tickets[i], kPerson);
                }
                else
                {
                    total += Math.Min(tickets[i], kPersonMinusOne);
                }
            }

            return total;
        }
    }
}
