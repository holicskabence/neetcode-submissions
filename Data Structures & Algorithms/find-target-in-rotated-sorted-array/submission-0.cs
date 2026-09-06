public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right)
        {
            int middle = (right - left) / 2 + left;

            if(nums[middle] == target)
            {
                return middle;
            }

            if(nums[left] == target)
            {
                return left;
            }

            if(nums[right] == target)
            {
                return right;
            }

            if(nums[middle] >= nums[right])
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }
}
