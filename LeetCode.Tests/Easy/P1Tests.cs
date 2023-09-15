using LeetCode.Easy.TwoSum;

namespace LeetCode.Tests.Easy;

public class P1Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
    public void Example1(int[] nums, int target)
    {
        Solution solution = new();
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Theory]
    [InlineData(new int[] { 3, 2, 4 }, 6)]
    public void Example2(int[] nums, int target)
    {
        Solution solution = new();
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Theory]
    [InlineData(new int[] { 3, 3 }, 6)]
    public void Example3(int[] nums, int target)
    {
        Solution solution = new();
        int[] result = solution.TwoSum(nums, target);
        Assert.Equal(new int[] { 0, 1 }, result);
    }
}
