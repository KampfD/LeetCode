using LeetCode.Easy.RemoveDuplicatesFromSortedArray;
namespace LeetCode.Tests.Easy;

public class P26Tests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 }, 5)]
    public void Example(int[] nums, int[] changedNums, int expected)
    {
        Solution solution = new();
        var result = solution.RemoveDuplicates(nums);

        Assert.True(nums
            .Intersect(changedNums)
            .Count() == changedNums.Length);
        Assert.Equal(expected, result);
    }
}