// Runtime: 62ms Beats 44.53%
// Memory Usage: 36.48MB Beats 85.70%
namespace LeetCode.Easy.FindTheIndexOfTheFirstOccurrenceInAString;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (haystack.Length - i < needle.Length)
                {
                    return -1;
                }
                if (IsContains(haystack, i, needle))
                {
                    return i;
                }
            }
        }
        return -1;
    }

    private bool IsContains(string haystack, int hIndex, string needle)
    {
        for (int j = 1; j < needle.Length; j++)
        {
            char h = haystack[hIndex + j];
            char n = needle[j];
            if (haystack[hIndex + j] != needle[j])
            {
                return false;
            }
        }
        return true;
    }
}
