using LeetCode.Easy.ValidParentheses;
namespace LeetCode.Tests.Easy;

public class P20Tests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    public void Example(string s, bool expected)
    {
        Solution solution = new();
        var result = solution.IsValid(s);
        Assert.Equal(expected, result);
    }
}