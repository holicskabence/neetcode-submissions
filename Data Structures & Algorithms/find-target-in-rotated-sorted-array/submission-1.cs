public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right){
            int middle = (right - left) / 2 + left;

            if(nums[middle] == target){
                return middle;
            }

            if(nums[left] <= nums[middle])
            {
                if(target < nums[middle] && target >= nums[left])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            else
            {
                if(target > nums[middle] && target <= nums[right])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
        }

        return nums[right] == target ? right : -1;
    }
}
