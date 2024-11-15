public class Solution
{
    public bool IsPalindrome(int x)
    {
        bool result = false;
        if (x < 0)
            return result;
        int i;
        i = 0;
        int[] numbers = getNumbers(x, out int j);
        while (i <= j)
        {
            result = numbers[i] == numbers[j - 1];
            if (!result)
                return result;
            i++; j--;
        }
        return result;
    }
    public int[] getNumbers(int num, out int digits)
    {
        int[] res = new int[12];
        int ten = 1;
        int i = 0;
        digits = 0;
        do
        {
            res[i] = num % 10;
            ten *= 10;
            digits++;
            num /= 10;
            i++;
        }
        while (num > 0);
        return res;
    }
}
