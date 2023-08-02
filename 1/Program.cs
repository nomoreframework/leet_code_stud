var TwoSum = (int[] nums, int target) => {
    int [] res = new int[2];
    for(int i = 0; i < nums.Length;i++){
        int j = i + 1;
        while(j != nums.Length){
            if(nums[i] + nums[j] == target) return res = new int [] {i,j};
            j++;
        }
        
    }
    return res;
};