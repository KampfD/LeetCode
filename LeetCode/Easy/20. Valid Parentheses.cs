// Runtime: 66ms Beats 75.60%
// Memory Usage: 37.66MB Beats 95.28%
namespace LeetCode.Easy.ValidParentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
        {
            return false;
        }
        int strLength = s.Length;
        Stack<char> stack = new(strLength / 2);
        for (int i = 0; i < strLength; i++)
        {
            char symbol = s[i];
            if (symbol == '(' || symbol == '[' || symbol == '{')
            {
                stack.Push(symbol);
            }
            else
            {
                if (stack.Count == 0 || GetPairSimbol(stack.Pop()) != symbol)
                {
                    return false;
                }
            }
        }
        if (stack.Count != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private char GetPairSimbol(char c) => c switch
    {
        '(' => ')',
        '[' => ']',
        '{' => '}',
        _ => throw new ArgumentException()
    };
}