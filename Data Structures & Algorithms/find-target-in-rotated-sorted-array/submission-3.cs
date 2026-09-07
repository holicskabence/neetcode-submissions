public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while(left <= right){
            int middle = (right - left) / 2 + left;

            Console.WriteLine($"left: {nums[left]}, middle: {nums[middle]}, right: {nums[right]}");
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
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
        }

        return nums[right] == target ? right : -1;
    }
}
