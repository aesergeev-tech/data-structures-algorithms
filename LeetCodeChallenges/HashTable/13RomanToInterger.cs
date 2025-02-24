namespace HashTable;

public partial class Solution {
    public int RomanToInt(string s) {
        var chars = s.ToCharArray();

        var map = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var result = 0;
        var n = chars.Length;
        for(var i=0; i < n; i++){
            var currentValue = map[chars[i]];
            if(i< n -1 && currentValue < map[chars[i+1]]){
                result -= currentValue;
            }else{
                result += currentValue;
            }
        }

        return result;
    }
}