// Runtime: 129ms Beats 56.25%
// Memory Usage: 42.50MB Beats 72.70%
namespace LeetCode.Easy.PlusOne;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int digitsLength = digits.Length;
        bool done = false;
        int counter = 1;
        do
        {
            if (digitsLength - counter < 0)
            {
                int[] result = new int[digitsLength + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, digitsLength);
                return result;
            }
            if (++digits[digitsLength - counter] == 10)
            {
                digits[digitsLength - counter] -= 10;
            }
            else
            {
                done = true;
            }
            counter++;
        } while (!done);
        return digits;
    }
}