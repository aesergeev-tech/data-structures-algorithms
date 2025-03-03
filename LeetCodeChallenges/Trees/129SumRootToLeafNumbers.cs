namespace Trees;

public partial class Solution
{
    public int SumNumbers(TreeNode root)
    {
        return Sum(root, 0);
    }

    private int Sum(TreeNode root, int sum)
    {
        if (root is null) return 0;
        if (root.left == null && root.right == null) return sum * 10 + root.val;
        return Sum(root.left, sum * 10 + root.val) + Sum(root.right, sum * 10 + root.val);
    }
}