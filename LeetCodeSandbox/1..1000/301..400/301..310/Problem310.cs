namespace LeetCodeSandbox._1._1000._301._400._301._310
{
    public class Problem310 : IProblem
    {
        public void Run()
        {
            var input1 = new int[][]
            {
                new int[] {1, 0},
                new int[] {1, 2},
                new int[] {1, 3},
            };
            var input2 = new int[][]
            {
                new int[] {3, 0},
                new int[] {3, 1},
                new int[] {3, 2},
                new int[] {3, 4},
                new int[] {5, 4},
            };
            var input3 = new int[][]
            {
            };
            var input4 = new int[][]
            {
                new int[] {0, 1},
            };
            var input5 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 2},
                new int[] {1, 3},
                new int[] {2, 4},
                new int[] {3, 5},
                new int[] {4, 6},
            }; 

            var input6 = new int[19999][];
            for (int i = 1; i < 19999; i++)
            {
                input6[i - 1] = new int[] {i, i + 1};
            }

            input6[19998] = new int[] {0, 1};

            Console.WriteLine("starting");
            var time1 = DateTime.Now;
            Console.WriteLine(String.Join(", ", FindMinHeightTrees(4, input1)));
            Console.WriteLine(String.Join(", ", FindMinHeightTrees(6, input2)));
            Console.WriteLine(String.Join(", ", FindMinHeightTrees(1, input3)));
            Console.WriteLine(String.Join(", ", FindMinHeightTrees(2, input4)));
            Console.WriteLine(String.Join(", ", FindMinHeightTrees(7, input5)));
            Console.WriteLine(String.Join(", ", FindMinHeightTrees(20000, input6)));
            var time2 = DateTime.Now;
            Console.WriteLine((time2 - time1).TotalMilliseconds);
        }

        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            var numOfConnections = new int[n];
            var visited = new bool[n];
            var graph2 = new List<int>[n];
            foreach (var edge in edges)
            {
                graph2[edge[0]] ??= new List<int>();
                graph2[edge[1]] ??= new List<int>();
                graph2[edge[0]].Add(edge[1]);
                graph2[edge[1]].Add(edge[0]);
                numOfConnections[edge[0]]++;
                numOfConnections[edge[1]]++;
            }

            var queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (numOfConnections[i] == 1)
                    queue.Enqueue(i);
            }

            int remainingVertexes = n;
            
            while (remainingVertexes > 2)
            {
                remainingVertexes -= queue.Count;
                var nextQueue = new Queue<int>();

                while (queue.Any())
                {
                    var i = queue.Dequeue();
                    if (numOfConnections[i] == 1)
                    {
                        foreach (var link in graph2[i])
                        {
                            numOfConnections[link]--;

                            if (numOfConnections[link] == 1)
                            {
                                nextQueue.Enqueue(link);
                            }
                        }

                        numOfConnections[i] = 0;
                        visited[i] = true;
                    }
                }

                queue = nextQueue;
            }

            if (!numOfConnections.Any(n => n > 0))
            {
                for (int i = 0; i < n; i++)
                {
                    if (!visited[i])
                    {
                        return new int[]{ i};
                    }
                }
            }

            var result = new List<int>(2);
            for (int i = 0; i < n; i++)
            {
                if (numOfConnections[i] >0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
