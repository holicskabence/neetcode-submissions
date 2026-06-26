public class Solution {
    public bool hasDuplicate(int[] nums) {
        var distinctNums = new List<int>();
        for(int i = 0; i < nums.Count(); i++)
        {
            if(distinctNums.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                distinctNums.Add(nums[i]);
            }
        }

        return false;
    }
}