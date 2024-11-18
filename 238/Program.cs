var print = (object obj) => Console.WriteLine(obj);
var arr = new Solution().ProductExceptSelf([-1, 1, 0, -3, 3]);

foreach (var i in arr)
    print(i);
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int length = nums.Length;
        int product = 1;
        int[] result = new int[length];
        int zerroCounter = 0;
        int index = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] != 0)
                product *= nums[i];
            else
            {
                zerroCounter++;
                index = i;
            }
        }
        if (zerroCounter < 2)
        {
            if (zerroCounter == 0)
                for (int i = 0; i < length; i++)
                    result[i] = (int)(product * Math.Pow(nums[i], -1));
            else
                result[index] = product;
        }
        return result;
    }
}