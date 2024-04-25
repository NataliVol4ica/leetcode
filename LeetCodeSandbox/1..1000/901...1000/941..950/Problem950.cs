namespace LeetCodeSandbox._1._1000._901._1000._941._950
{
    public class Problem950 : IProblem
    {
        public void Run()
        {
            List<int[]> inputs = new List<int[]>()
            {
               new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11,},
               new int[] {17, 13, 11, 2, 3, 5, 7},
               new int[] {1, 1000},
               Enumerable.Range(0, 25).ToArray(),
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(Tools.Print(input) + ": " + Tools.Print(DeckRevealedIncreasing(input)) );
            }
        }
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            var sortedDeck = deck.ToList();
            sortedDeck.Sort();
            
            var result = new int[sortedDeck.Count];

            var simulation = new Queue<int>(Enumerable.Range(0, deck.Length));
            var simulationResult = new int[deck.Length];
            
            for (int i = 0; i < deck.Length; i++)
            {
                simulationResult[i] = simulation.Dequeue();
                if (i < deck.Length - 1)
                    simulation.Enqueue(simulation.Dequeue());
            }

            for (int i = 0; i < deck.Length; i++)
            {
                result[simulationResult[i]] = sortedDeck[i];
            }

            return result;
        }
    }
}
