public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int currentMaxIndex = 0;
        int left = 1;
        var result = new List<int>();

        for(int i = 0; i < k; i++)
        {
            if(i <= k && nums[currentMaxIndex] < nums[i])
            {
                currentMaxIndex = i;
            }

            if(i + 1 == k)
            {

                result.Add(nums[currentMaxIndex]);
            }
        }

        for(int i = k; i < nums.Length; i++)
        {
            if(left < currentMaxIndex)
            {
                if(nums[left] < nums[i] && nums[i] >= nums[currentMaxIndex])
                {
                    result.Add(nums[i]);
                    currentMaxIndex = i;
                }
                else
                {
                    result.Add(nums[currentMaxIndex]);
                }
            }
            else
            {
                int counter = left;
                currentMaxIndex = left;
                while(counter <= i)
                {
                    if(nums[counter] > nums[currentMaxIndex])
                    {
                        currentMaxIndex = counter;
                    }

                    counter++;
                }
                
                result.Add(nums[currentMaxIndex]);
            }

            left++;
        }

        return result.ToArray();
    }
}
