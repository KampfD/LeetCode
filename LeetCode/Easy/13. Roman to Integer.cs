// Runtime: 67ms Beats 65.83%
// Memory Usage: 46.26MB Beats 97.83%
namespace LeetCode.Easy.RomanToInteger;

public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            result += s[i] switch
            {
                'V' when i > 0 && s[i - 1] == 'I' => GetNumber(s[i]) - 2,
                'X' when i > 0 && s[i - 1] == 'I' => GetNumber(s[i]) - 2,
                'L' when i > 0 && s[i - 1] == 'X' => GetNumber(s[i]) - 20,
                'C' when i > 0 && s[i - 1] == 'X' => GetNumber(s[i]) - 20,
                'D' when i > 0 && s[i - 1] == 'C' => GetNumber(s[i]) - 200,
                'M' when i > 0 && s[i - 1] == 'C' => GetNumber(s[i]) - 200,
                _ => GetNumber(s[i]),
            };
        }
        return result;
    }

    private int GetNumber(char romanSymbol) => romanSymbol switch 
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => 0
    };
}