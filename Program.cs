namespace Assignment_8._2
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val) => this.val = val;
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        private bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left?.val != right?.val)
                return false;

            return IsMirror(left?.left, right?.right) && IsMirror(left?.right, right?.left);
        }

        static void Main()
        {
            // Example usage:
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);

            Solution solution = new Solution();
            Console.WriteLine($"Is the tree symmetric? {solution.IsSymmetric(root)}");
        }
    }
}
