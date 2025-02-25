namespace HashTable;

public partial class Solution {
    public int MissingNumber(int[] nums) {
        var n = nums.Length; 
        var expectedSum = n*(n+1)/2;
        var actualSum = 0;
        foreach(var x in nums){
            actualSum+=x;
        }
        return expectedSum - actualSum;
    }
}