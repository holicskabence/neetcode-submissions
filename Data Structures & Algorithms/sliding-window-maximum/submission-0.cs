public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int currentWindowMax = 0;
        int left = 0;
        var result = new List<int>();


        for(int i = 0; i < k; i++){
            if(i <= k && currentWindowMax < nums[i])
            {
                currentWindowMax = nums[i];
            }

            if(i + 1 == k)
            {
                result.Add(currentWindowMax);
            }
        }

        for(int i = k; i < nums.Length; i++){
            if(nums[left] < nums[i] && nums[i] >= currentWindowMax)
            {
                result.Add(nums[i]);
                currentWindowMax = nums[i];
            }
            else
            {
                result.Add(currentWindowMax);
            }
        }

        return result.ToArray();
    }
}
