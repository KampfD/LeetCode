// Runtime: 52ms
// Memory Usage: 29.97MB
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
