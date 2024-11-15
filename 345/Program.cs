var printf = (object msg) => Console.WriteLine(msg);
var print = (object msg) => Console.Write(msg);

print(new Solution().ReverseVowels("AEBU")); //UEBA
print(new Solution().ReverseVowels("IceCreAm")); //UEBA

public class Solution
{
    public string ReverseVowels(string s)
    {
        int length = s.Length;
        char[] result = new char[length];
        int i, j;
        j = length - 1;
        if (length == 1)
            return s;
        for (i = 0; i <= j; i++)
        {
            if (isVowel(s[i]))
            {
                while (j >= i)
                {
                    if (isVowel(s[j]))
                    {
                        result[i] = s[j];
                        result[j] = s[i];
                        j--;
                        break;
                    }
                    result[j] = s[j];
                    j--;
                }
            }
            else
                result[i] = s[i];
        }
        return new string(result);
    }

    private static readonly char[] sourceArray = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

    private bool isVowel(char c) => sourceArray.Contains(c);
}