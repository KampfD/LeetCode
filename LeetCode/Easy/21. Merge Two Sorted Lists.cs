// Runtime: 78ms Beats 75.98%
// Memory Usage: 39.95MB Beats 66.14%
namespace LeetCode.Easy.MergeTwoSortedLists;
# nullable disable


public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    
    public override string ToString() // для отладки
    {
        return $"Val: {val}, Next: {(next != null ? next.val : "null")}";
    }
}

public class Solution
{
    // сортировка слиянием
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode headListNode = new();
        ListNode mergedListNode = headListNode;
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                mergedListNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                mergedListNode.next = list2;
                list2 = list2.next;
            }
            mergedListNode = mergedListNode.next;
        }
        mergedListNode.next = list1 ?? list2;
        return headListNode.next;
    }
}