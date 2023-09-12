// Runtime: 
// Memory Usage: 
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

    public override string ToString()
    {
        return $"Val: {val}, Next: {(next != null ? next.val : "null")}";
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode headListNode;
        ListNode mergedListNode;
        if (list1.val <= list2.val)
        {
            mergedListNode = list1;
            list1 = list1.next;
        }
        else
        {
            mergedListNode = list2;
            list2 = list2.next;
        }
        headListNode = mergedListNode;

        while (list1 != null || list2 != null)
        {
            if (list1.val <= list2.val)
            {
                mergedListNode = list1;
                list1 = list1.next;
            }
            else
            {
                mergedListNode = list2;
                list2 = list2.next;
            }
        }





        /*while (mergedListNode.next != null)
        {
            mergedListNode = mergedListNode.next;
        }
        mergedListNode.next = list2;*/


        return headListNode;
    }
}