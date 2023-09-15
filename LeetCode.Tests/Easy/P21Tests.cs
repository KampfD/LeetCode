using LeetCode.Easy.MergeTwoSortedLists;
namespace LeetCode.Tests.Easy;

public class P21Tests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Example(ListNode? list1, ListNode? list2, List<int> expected)
    {
        Solution solution = new();
        var result = solution.MergeTwoLists(list1, list2);

        List<int> valueList;
        if (list1 == null && list2 == null)
        {
            Assert.Null(result);
            return;
        }
        else if (list1 != null && list2 == null)
        {
            valueList = GetValList(list1);
        }
        else if (list1 == null && list2 != null)
        {
            valueList = GetValList(list2);
        }
        else
        {
            valueList = GetValList(result);
        }
        Assert.True(expected.SequenceEqual(valueList));
    }

    private List<int> GetValList(ListNode listNode)
    {
        List<int> list = new();
        while (listNode.next != null)
        {
            list.Add(listNode.val);
            listNode = listNode.next;
        }
        list.Add(listNode.val);
        return list;
    }

    public static IEnumerable<object?[]> Data =>
        new List<object?[]>
        {
            new object[] 
            { 
                new ListNode(1, new ListNode(2, new ListNode (4))),
                new ListNode(1, new ListNode(3, new ListNode (4))),
                new List<int> { 1, 1, 2, 3, 4, 4 },
            },
            new object?[]
            {
                null,
                null,
                new List<int>(),
            },
            new object?[]
            {
                new ListNode(0),
                null,
                new List<int> { 0 },
            },
        };
}