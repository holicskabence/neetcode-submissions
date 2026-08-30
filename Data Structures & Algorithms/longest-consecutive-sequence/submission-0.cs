public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int longest = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(!set.Contains(nums[i] - 1))
            {
                int currentLength = 1;
                while(set.Contains(nums[i] + currentLength)){
                    currentLength++;
                }

                longest = Math.Max(currentLength, longest);
            }
        }

        return longest;
    }
}
