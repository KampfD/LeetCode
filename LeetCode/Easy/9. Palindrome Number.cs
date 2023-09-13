// Runtime: 52ms Beats 42.89%
// Memory Usage: 29.97MB Beats 62.90%
namespace LeetCode.Easy.PalindromeNumber;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x >= 0 && x < 10)
        {
            return true;
        }
        if (x < 0 || x % 10 == 0)
        {
            return false;
        }
        string number = x.ToString();
        for (int i = 0; i < number.Length / 2; i++)
        {
            if (number[i] != number[number.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
