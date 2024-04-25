namespace LeetCodeSandbox._1001._2000._1901._2000._1971._1980
{
    public class Problem1971 : IProblem
    {
        public void Run()
        {
            var input1 = new int[][]
            {
                new int[] {0, 1 },
                new int[] { 1, 2 },
                new int[] {2, 0},
            };
            var input2 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 3, 5 },
                new int[] { 5, 4 },
                new int[] { 4, 3 },
            };

            Console.WriteLine(ValidPath(3, input1, 0, 2));
            Console.WriteLine(ValidPath(6, input2, 0, 5));
        }

        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (source == destination) return true;
            if (edges.Length == 0) return false;

            var visited = new bool[n];
            var connections = new List<int>[n];
            for (int i = 0; i < edges.Length; i++)
            {
                if (connections[edges[i][0]] is null)
                    connections[edges[i][0]] = new List<int>();
                if (connections[edges[i][1]] is null)
                    connections[edges[i][1]] = new List<int>();
                connections[edges[i][0]].Add(edges[i][1]);
                connections[edges[i][1]].Add(edges[i][0]);
            }

            var queue = new Queue<int>();
            queue.Enqueue(source);
            visited[source] = true;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                foreach (var dest in connections[current])
                {
                    if (dest == destination)
                        return true;
                    if (visited[dest])
                        continue;
                    queue.Enqueue(dest);
                    visited[dest] = true;
                }
            }

            return false;
        }
    }
}
