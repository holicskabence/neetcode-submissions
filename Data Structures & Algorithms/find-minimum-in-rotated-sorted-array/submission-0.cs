public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            int middle = (right - left) / 2 + left;
            
            if(nums[middle] >= nums[right])
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }

        return nums[right];
    }
}
