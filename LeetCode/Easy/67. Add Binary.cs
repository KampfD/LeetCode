// Runtime: 
// Memory Usage: 
using System.Text;

namespace LeetCode.Easy.AddBinary;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        int minLength = a.Length < b.Length ? a.Length : b.Length;
        StringBuilder sb = new(minLength);

        int overflowCounter = 0;
        int i = 0;
        for (; i < minLength; i++)
        {
            if (a[i] == '0' && b[i] == '0')
            {
                if (overflowCounter != 0)
                {
                    sb.Append('1');
                    overflowCounter--;
                }
                else
                {
                    sb.Append('0');
                }
            }
            else if (a[i] == '1' && b[i] == '1')
            {
                if (overflowCounter != 0)
                {
                    sb.Append('1');
                }
                else
                {
                    sb.Append('0');
                    overflowCounter++;
                }
            }
            else // 0 & 1 or 1 & 0
            {
                if (overflowCounter != 0)
                {
                    sb.Append('0');
                }
                else
                {
                    sb.Append('1');
                }
            }
        }


        //string 
        while (overflowCounter != 0)
        {
            if (a[i] == '0')
            {

            }
        }


        string result = sb.ToString();



        return "";
    }
}