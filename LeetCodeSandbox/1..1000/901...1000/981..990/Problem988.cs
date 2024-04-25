using System.Globalization;
using System.Text;

namespace LeetCodeSandbox._1._1000._901._1000._981._990
{
    public class Problem988 : IProblem
    {
        public void Run()
        {
            var input1 = new TreeNode(0, new TreeNode(1, new TreeNode(3), new TreeNode(4)),
                new TreeNode(2, new TreeNode(3), new TreeNode(4)));

            Console.WriteLine(SmallestFromLeaf(input1));

            var input2 = new TreeNode(25, new TreeNode(1, new TreeNode(1), new TreeNode(3)),
                new TreeNode(3, new TreeNode(0), new TreeNode(2)));

            Console.WriteLine(SmallestFromLeaf(input2));

            var input3 = new TreeNode(2, new TreeNode(2, null, new TreeNode(1, new TreeNode(0))), new TreeNode(1, new TreeNode(0)));

            Console.WriteLine(SmallestFromLeaf(input3));

            var input4 = new TreeNode(2 );

            Console.WriteLine(SmallestFromLeaf(input4));
        }


        //Definition for a binary tree node.
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

        string? _smallest;

        public string SmallestFromLeaf(TreeNode root)
        {
            _smallest = string.Empty;
            DFS(root, string.Empty);
            return _smallest;
        }

        public void DFS(TreeNode node, string current)
        {
            if (node is null)
                return;

            current = (char) (node.val + 'a') + current;

            if (node.left is null && node.right is null &&
                (string.IsNullOrEmpty(_smallest) ||
                 String.Compare(_smallest, current, StringComparison.Ordinal) > 00))
            {
                _smallest = current;
                return;
            }

            if (node.left is not null)
                DFS(node.left, current);

            if (node.right is not null)
                DFS(node.right, current);
        }
    }
}
