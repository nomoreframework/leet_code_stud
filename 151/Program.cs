using System.Text;
public class Solution
{
    public string ReverseWords(string s)
    {

        int length = s.Length;
        if (length == 1 || length == 0)
            return s;

        var substrList = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new(length);
        for (int i = substrList.Length - 1; i > 0; i--)
        {
            result.Append(substrList[i]);
            result.Append(' ');
        }
        result.Append(substrList[0]);
        return result.ToString();
    }
}