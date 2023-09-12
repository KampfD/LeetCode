// Runtime: 200ms
// Memory Usage: 44.31MB
namespace LeetCode.Easy.TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }
                int summ = nums[i] + nums[j];
                if (summ == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null!;
    }
}