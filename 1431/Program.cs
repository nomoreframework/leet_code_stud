public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxValue = 0;
        List<bool> res = new ();
        for(int i = 0; i < candies.Length;i++)
                maxValue = candies[i] > maxValue ? candies[i] : maxValue;
        for(int i = 0; i < candies.Length;i++)
            res.Add(candies[i] + extraCandies>= maxValue);
            return res;
    }
}