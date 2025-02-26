using System.Text;

namespace Math;

public partial class Solution
{
    public string ConvertToBase7(int num) {
        if (num == 0) return "0";

        var result = new StringBuilder();
        var isNegative = num < 0; 
        num = System.Math.Abs(num);
        while(num > 0){
            var nextSym = num % 7;
            result.Append(nextSym.ToString());
            num/=7;
        }

        var numberAsStr = new string(result.ToString().ToCharArray().Reverse().ToArray());
        return isNegative ? $"-{numberAsStr}" : numberAsStr;
    }
}