var print = (object obj) => Console.WriteLine(obj);



public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
            return "";
        int str1Length = str1.Length;
        int str2Length = str2.Length;

        return str1[..GCD(str1Length, str2Length)];
    }
    private static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }
}