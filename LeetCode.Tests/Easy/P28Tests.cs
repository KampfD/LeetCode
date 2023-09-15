using LeetCode.Easy.FindTheIndexOfTheFirstOccurrenceInAString;
namespace LeetCode.Tests.Easy;

public class P28Tests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    public void Example(string haystack, string needle, int expected)
    {
        Solution solution = new();
        var result = solution.StrStr(haystack, needle);
        Assert.Equal(expected, result);
    }
}