using LeetCode.Easy.RomanToInteger;
namespace LeetCode.Tests.Easy;

public class P13Tests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Example(string s, int expected)
    {
        Solution solution = new();
        var result = solution.RomanToInt(s);
        Assert.Equal(expected, result);
    }
}