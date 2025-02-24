namespace Array;

public partial class Solution {
    public int SingleNumber(int[] nums) {
        var res = 0;
        foreach(var x in nums){
            res^=x;
        }
        return res;
    }
}