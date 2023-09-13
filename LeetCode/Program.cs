using LeetCode.Easy.MergeTwoSortedLists;

Solution solution = new();

ListNode l14 = new(4, null);
ListNode l12 = new(2, l14);
ListNode l11 = new(1, l12);

ListNode l24 = new(4, null);
ListNode l23 = new(3, l24);
ListNode l21 = new(1, l23);



var result = solution.MergeTwoLists(l11, l21);
Console.WriteLine("End");

//Console.WriteLine(result);

/*foreach (int r in result)
{
    Console.WriteLine(r);
}*/

//ListNode? resultList = l11;

var outListNode = result;
while (outListNode.next != null)
{
    Console.WriteLine(outListNode);
    outListNode = outListNode.next;
}
Console.WriteLine(outListNode);








ConsoleKeyInfo keyInfo;
do keyInfo = Console.ReadKey();
while (keyInfo.Key != ConsoleKey.Enter);

