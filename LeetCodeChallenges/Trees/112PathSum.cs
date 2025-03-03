namespace Trees;

public partial class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;
        if (root.left == null && root.right == null)
        {
            return root.val == targetSum;
        }

        if (root.left != null) root.left.val += root.val;
        if (root.right != null) root.right.val += root.val;
        return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
    }
}