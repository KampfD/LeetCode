using LeetCode.Easy.PalindromeNumber;
namespace LeetCode.Tests.Easy;

public class P9Tests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void Example(int x, bool expected)
    {
        Solution solution = new();
        var result = solution.IsPalindrome(x);
        Assert.Equal(expected, result);
    }
}