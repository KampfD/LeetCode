using LeetCode.Easy.SearchInsertPosition;
namespace LeetCode.Tests.Easy;

public class P35Tests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
    public void Example(int[] nums, int target, int expected)
    {
        Solution solution = new();
        var result = solution.SearchInsert(nums, target);
        Assert.Equal(expected, result);
    }
}