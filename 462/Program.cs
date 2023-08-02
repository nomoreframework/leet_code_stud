var MinMovies2 = (int [] nums) =>{
    Array.Sort(nums);
    var res = 0;        
    foreach(var num in nums)
        res += Math.Abs(nums[nums.Length / 2] - num);
    return res;
};
