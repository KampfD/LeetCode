// Runtime: 151ms Beats 21.65%
// Memory Usage: 49.90MB Beats 6.43%
namespace LeetCode.Easy.RemoveDuplicatesFromSortedArray;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        List<int> uniqueValues = new(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if (uniqueValues
                .Where(v => v == nums[i])
                .Count() == 0)
            {
                uniqueValues.Add(nums[i]);
                if (i != uniqueValues.Count - 1)
                {
                    Reindex(nums, i, uniqueValues.Count - 1);
                }
            }
        }
        return uniqueValues.Count;
    }

    private void Reindex(int[] nums, int fromIndex, int toIndex)
    {
        // fromIndex > toIndex always
        int reindexValue = nums[fromIndex];
        Array.Copy(nums, toIndex, nums, toIndex + 1, fromIndex - toIndex);
        nums[toIndex] = reindexValue;
    }
}