// Runtime: 95ms Beats 48.57%
// Memory Usage: 39.76MB Beats 88.51%
namespace LeetCode.Easy.LongestCommonPrefix;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string firstStr = strs[0];
        int matchesCount = firstStr.Length;
        for (int i = 1; i < strs.Length; i++)
        {
            if (matchesCount > strs[i].Length)
            {
                matchesCount = strs[i].Length;
            }
            for (int j = 0; j < matchesCount; j++)
            {
                if (firstStr[j] != strs[i][j])
                {
                    matchesCount = j;
                    break;
                }
            }
        }
        return firstStr.Substring(0, matchesCount);
    }
}