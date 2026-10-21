public class Solution {
    public List<int> MajorityElement(int[] nums) {
        var result = new List<int>();
        int counter = 1;
        int limit = nums.Length / 3;

        nums = nums.ToList().OrderBy(x => x).ToArray();

        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i - 1])
            {
                if(counter > limit && !result.Any(x => x == nums[i - 1]))
                {
                    result.Add(nums[i - 1]);
                }

                counter = 1;
            }
            else
            {
                counter++;
            }
        }

        if(counter > limit && !result.Any(x => x == nums[nums.Length - 1]))
        {
            result.Add(nums[nums.Length - 1]);
        }

        return result;
    }
}