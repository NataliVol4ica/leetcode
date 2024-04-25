namespace LeetCodeSandbox._1001._2000._1601._1700._1691._1700
{
    public class Problem1700 : IProblem
    {
        record Sample(int[] Students, int[] Sandwiches);

        public void Run()
        {
            var samples = new List<Sample>
            {
                new Sample(new[] {1, 1, 0, 0}, new[] {0, 1, 0, 1}),
                new Sample(new[] {1, 1, 1, 0, 0, 1}, new[] {1, 0, 0, 0, 1, 1}),
            };

            foreach (var sample in samples)
            {
                Console.WriteLine("====");
                Console.WriteLine("Students: " + string.Join(", ", sample.Students));
                Console.WriteLine("Sandwiches: " + string.Join(", ", sample.Sandwiches));
                Console.WriteLine("Result: " + CountStudents(sample.Students, sample.Sandwiches));
            }
        }

        public int CountStudents(int[] students, int[] sandwiches)
        {
            int numOfTakenSandwichesInRotation;
            int currentSandwich = 0;

            var studentQueue = new Queue<int>(students);

            do
            {
                numOfTakenSandwichesInRotation = 0;
                int numOfStudentsInCurrentRotation = studentQueue.Count;

                for (int i = 0; i < numOfStudentsInCurrentRotation; i++)
                {
                    var student = studentQueue.Dequeue();
                    if (student == sandwiches[currentSandwich])
                    {
                        currentSandwich++;
                        numOfTakenSandwichesInRotation++;
                    }
                    else
                    {
                        studentQueue.Enqueue(student);
                    }
                }
            } while (numOfTakenSandwichesInRotation > 0 && currentSandwich < sandwiches.Length);

            return studentQueue.Count;
        }
    }
}
