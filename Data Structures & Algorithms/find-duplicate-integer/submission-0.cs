public class Solution {
    public int FindDuplicate(int[] nums) {
        var seen = new HashSet<int>();
        for(int i = 0; i <nums.Length; i++)
        {
            if(!seen.Add(nums[i]))
            {
                return nums[i];
            }
        }

        return -1;
    }
}
