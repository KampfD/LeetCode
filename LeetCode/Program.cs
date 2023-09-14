using LeetCode.Easy.SearchInsertPosition;

Solution solution = new();


var result = solution.SearchInsert(new int[] { 1, 3, 5 }, 1);
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

