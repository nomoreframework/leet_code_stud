public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int l = nums.Length - 1;
        int j = 1;
        for(int i = 0; i < l; i++){
            if(nums[i] == 0){
                while(nums[j] == 0 & j < l)
                    j++;
                nums[i] = nums[j];
                nums[j] = 0;
            }
            else 
                j++;
        }
    }
}
