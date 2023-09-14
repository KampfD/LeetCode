// Runtime: 54ms Beats 86.23%
// Memory Usage: 36.70MB Beats 53.36%
namespace LeetCode.Easy.LengthOfLastWord;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s
            .Split(' ')
            .Where(str => str.Length > 0)
            .Last()
            .Length;
    }
}