using System.Text;

namespace LeetCodeSandbox._1001._2000._1501._1600._1541._1550
{
    public class Problem1544 : IProblem
    {
        public void Run()
        {
            var inputs = new List<string>
            {
                "leEeetcode",
                "abBAcC",
                "s",
                "GAhHagVTmQvDbUubUuBdVqMtv",
            };

            foreach (var input in inputs)
            {
                Console.WriteLine(input + ": " + MakeGood(input));
            }
        }

        public string MakeGood(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            LinkedList? head = Convert(s);
            LinkedList? current = head;

            while (current?.Next != null)
            {
                if (AreAdjacentChars(current))
                {
                    if (current.Previous is null)
                    {
                        head = current.Next?.Next;
                        if (head is not null)
                            head.Previous = null;
                        current = head;
                    }
                    else
                    {
                        current.Previous.Next = current.Next?.Next;
                        if (current.Previous?.Next is not null)
                            current.Previous.Next.Previous = current.Previous;
                        current = current?.Previous; // Check once again
                    }
                }
                else
                {
                    current = current.Next;
                }
            }

            return Convert(head);
        }

        private string Convert(LinkedList? l)
        {
            if (l is null)
                return string.Empty;

            StringBuilder builder = new StringBuilder();
            
            while (l is not null)
            {
                builder.Append(l.Value);
                l = l.Next;
            }

            return builder.ToString();
        }

        private LinkedList Convert(string s)
        {
            LinkedList head = new LinkedList(s[0]);
            LinkedList current;
            LinkedList previous = head;

            for (int i = 1; i < s.Length; i++)
            {
                current = new LinkedList(s[i], previous: previous);
                previous.Next = current;
                previous = current;
            }

            return head;
        }

        private const int CharDiff = 32;

        private bool AreAdjacentChars(LinkedList? item)
        {
            var a = item?.Value;
            var b = item?.Next?.Value;

            if (a is null || b is null)
                return false;

            if (a - CharDiff == b || a + CharDiff == b)
                return true;

            return false;
        }

        private class LinkedList
        {
            public char Value { get; set; }
            public LinkedList? Next { get; set; }
            public LinkedList? Previous { get; set; }
            public LinkedList(char value, LinkedList? next = null, LinkedList? previous = null)
            {
                Value = value;
                Next = next;
                Previous = previous;
            }
    };
}
}
