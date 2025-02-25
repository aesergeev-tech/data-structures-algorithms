namespace HashTable;

public partial class Solution
{
    public IList<int> FindDuplicates(int[] nums)
    {
        var result = new List<int>();
        var n = nums.Length;
        for (var i = 0; i < n; i++)
        {
            while (nums[nums[i] - 1] != nums[i] && i != nums[i] - 1)
            {
                var tmp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = tmp;
            }
        }

        for (var i = 0; i < n; i++)
        {
            if (nums[i] - 1 != i) result.Add(nums[i]);
        }

        return result;
    }
}