using LeetCode.Easy.LengthOfLastWord;
namespace LeetCode.Tests.Easy;

public class P58Tests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void Example(string s, int expected)
    {
        Solution solution = new();
        var result = solution.LengthOfLastWord(s);
        Assert.Equal(expected, result);
    }
}