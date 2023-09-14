// Runtime: 76ms Beats 85.39%
// Memory Usage: 39.34MB Beats 83.04%
namespace LeetCode.Easy.SearchInsertPosition;

public class Solution // Бинарный поиск O(log n)
{
    public int SearchInsert(int[] nums, int target)
    {
        if (target < nums[0])
        {
            return 0;
        }
        else if (target > nums[^1])
        {
            return nums.Length;
        }
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int middle = left + (right - left) / 2;
            int middleValue = nums[middle];
            if (target < middleValue
                && nums[middle - 1] < target)
            {
                return middle;
            }
            else if (target < middleValue)
            {
                right = middle - 1;
            }
            else if (target > middleValue)
            {
                left = middle + 1;
            }
            else return middle;
        }
        return -1;
    }
}


// Runtime: 87ms Beats 31.61%
// Memory Usage: 39.16MB Beats 96.62%
public class Solution2 // O(n)
{
    public int SearchInsert(int[] nums, int target)
    {
        if (target < nums[0])
        {
            return 0;
        }
        int numLength = nums.Length;
        for (int i = 0; i < numLength; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
            else if (i < numLength -1 
                && nums[i + 1] > target)
            {
                return i + 1;
            }
            else if (i == numLength - 1)
            {
                return numLength;
            }
        }
        return -1;
    }
}