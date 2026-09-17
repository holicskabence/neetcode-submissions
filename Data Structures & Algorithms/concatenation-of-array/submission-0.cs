public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ans = new int[nums.Length * 2];
        int left = 0;
        for(int i = 0; i < ans.Length; i++)
        {
            if(left == nums.Length)
            {
                left = 0;
            }
            
            ans[i] = nums[left];
            left++;
        }

        return ans;
    }
}