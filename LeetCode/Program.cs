using LeetCode.Easy.MergeTwoSortedLists;

Solution solution = new();

ListNode l14 = new ListNode(4, null);
ListNode l12 = new ListNode(2, l14);
ListNode l11 = new ListNode(1, l12);

ListNode l24 = new ListNode(4, null);
ListNode l23 = new ListNode(3, l24);
ListNode l21 = new ListNode(1, l23);



var result = solution.MergeTwoLists(l11, l21);
Console.WriteLine("End");

//Console.WriteLine(result);

/*foreach (int r in result)
{
    Console.WriteLine(r);
}*/

//ListNode? resultList = l11;
while (result.next != null)
{
    Console.WriteLine(result);
    result = result.next;
}








ConsoleKeyInfo keyInfo;
do keyInfo = Console.ReadKey();
while (keyInfo.Key != ConsoleKey.Enter);

