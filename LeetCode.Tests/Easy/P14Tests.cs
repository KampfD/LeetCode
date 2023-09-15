using LeetCode.Easy.LongestCommonPrefix;
namespace LeetCode.Tests.Easy;

public class P14Tests
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void Example(string[] strs, string expected)
    {
        Solution solution = new();
        var result = solution.LongestCommonPrefix(strs);
        Assert.Equal(expected, result);
    }
}