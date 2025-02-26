namespace Math;

public partial class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;

        if (k > n) k %= n;
        var rotatedNums = new int[n];

        for (int i = n - k, j = 0; i < n; i++, j++)
        {
            rotatedNums[j] = nums[i];
        }

        for (int i = 0, j = k; i < n - k; i++, j++)
        {
            rotatedNums[j] = nums[i];
        }

        for (var i = 0; i < n; i++)
        {
            nums[i] = rotatedNums[i];
        }
    }
}