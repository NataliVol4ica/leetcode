namespace LeetCodeSandbox._1._1000._101._200._121._130
{
    public class Problem129 : IProblem
    {
        public void Run()
        {
            var root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            var root2 = new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0));
            Console.WriteLine(SumNumbers(root2));
        }

        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode? left;
            public TreeNode? right;

            public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public int SumNumbers(TreeNode root)
        {
            return CountSum(root, 0);
        }

        private int CountSum(TreeNode? root, int currentNumber)
        {
            if (root is null) return 0;

            if (root.left is null && root.right is null)
            {
                return currentNumber * 10 + root.val;
            }

            return CountSum(root.left, currentNumber * 10 + root.val) + CountSum(root.right, currentNumber * 10 + root.val);
        }
    }
}
