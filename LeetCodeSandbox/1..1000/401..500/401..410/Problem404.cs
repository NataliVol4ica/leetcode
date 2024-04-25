namespace LeetCodeSandbox._1._1000._401._500._401._410
{
    public class Problem404 : IProblem
    {
        public void Run()
        {
            var input = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            Console.WriteLine(SumOfLeftLeaves(input));
        }

        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public int SumOfLeftLeaves(TreeNode root)
        {

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int result = 0;

            while (queue.Count > 0)
            {
                var nodeToCheck = queue.Dequeue();
                if (nodeToCheck.left is not null)
                    queue.Enqueue(nodeToCheck.left);
                if (nodeToCheck.right is not null)
                    queue.Enqueue(nodeToCheck.right);
                if (nodeToCheck.left is null)
                    continue;
                if (nodeToCheck.left.left is null && nodeToCheck.left.right is null)
                    result += nodeToCheck.left.val;
            }

            return result;
        }
    }
}
