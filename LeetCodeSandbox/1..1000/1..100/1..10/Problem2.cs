namespace LeetCodeSandbox._1._1000._1._100._1._10
{
    public class Problem2 : IProblem
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            ListNode previous = null;

            int nextIncrement = 0;
            while (l1 is not null || l2 is not null)
            {
                var sum = (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val) + nextIncrement;
                nextIncrement = sum / 10;

                var newNode = new ListNode(sum % 10);

                if (result is null)
                    result = newNode;
                else
                    previous.next = newNode;

                previous = newNode;
                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (nextIncrement > 0)
                previous.next = new ListNode(nextIncrement);

            return result;
        }
    }
}
