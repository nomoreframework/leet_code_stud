var MinSubArrayLen = (int target, int[] nums) =>{
        int arr_length = nums.Length;
        int sum = 0;
        int left_pointer = 0;
        int length = int.MaxValue;
        for(int i = 0; i < arr_length;i++){
            sum += nums[i];
            while(sum >= target){
                length = Math.Min(length, i + 1 - left_pointer);
                sum -= nums[left_pointer++];
            }
        }
        return length != int.MaxValue ? length : 0;
};
Console.WriteLine(MinSubArrayLen(4,new int []{1,4,4}));