using LeetCode.Easy.PlusOne;
namespace LeetCode.Tests.Easy;

public class P66Tests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    public void Example(int[] digits, int[] expected)
    {
        Solution solution = new();
        var result = solution.PlusOne(digits);
        Assert.True(result.SequenceEqual(expected));
    }
}