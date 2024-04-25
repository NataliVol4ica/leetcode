namespace LeetCodeSandbox._1._1000._601._700._621._630
{
    public class Problem623 : IProblem
    {
        public void Run()
        {
            var root1 = new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(1)),
                new TreeNode(6, new TreeNode(5)));
            var root2 = new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(1)));

            var result = AddOneRow(root1, 1, 2);
            result = AddOneRow(root2, 1, 3);
            result = AddOneRow(root1, 1, 1);
            result = AddOneRow(root1, 1, 4);
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
        
        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
                return new TreeNode(val, root);
            depth--;

            List<TreeNode> currentGeneration = new List<TreeNode> { root };
            List<TreeNode> newGeneration;

            while (depth > 1)
            {
                newGeneration = new List<TreeNode>();
                foreach (var node in currentGeneration)
                {
                    if (node.left is not null)
                        newGeneration.Add(node.left);
                    if (node.right is not null)
                        newGeneration.Add(node.right);
                }

                depth--;
                currentGeneration = newGeneration;
            }

            foreach (var node in currentGeneration)
            {
                node.left = new TreeNode(val, node.left);
                node.right = new TreeNode(val, null, node.right);
            }

            return root;
        }
    }
}
