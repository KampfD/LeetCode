using System.Linq;
using LeetCode.Easy.MergeTwoSortedLists;


Solution solution = new();


var result = solution.MergeTwoLists(
    new ListNode(1, new ListNode(2, new ListNode(4))),
    new ListNode(1, new ListNode(3, new ListNode(4))));



List<int> valueList = new();
List<int> patternList = new() { 1, 1, 2, 3, 4, 5 };

while (result.next != null)
{
    valueList.Add(result.val);
    result = result.next;
}
valueList.Add(result.val);



var r =
patternList.SequenceEqual<int>(valueList);

Console.WriteLine(result);


/*foreach (int r in result)
{
    Console.WriteLine(r);
}*/

//ListNode? resultList = l11;

/*var outListNode = result;
while (outListNode.next != null)
{
    Console.WriteLine(outListNode);
    outListNode = outListNode.next;
}
Console.WriteLine(outListNode);*/







Console.WriteLine("End");
ConsoleKeyInfo keyInfo;
do keyInfo = Console.ReadKey();
while (keyInfo.Key != ConsoleKey.Enter);

