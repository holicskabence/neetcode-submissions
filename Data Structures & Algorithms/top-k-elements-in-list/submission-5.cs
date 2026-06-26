public class Solution {
public int[] TopKFrequent(int[] nums, int k)
        {
 var dict = new Dictionary<int, int>() { { nums[0], 1 } };

for (int i = 1; i < nums.Count(); i++)
{
    if (dict.ContainsKey(nums[i]))
    {
        dict[nums[i]]++;
    }
    else
    {
        dict[nums[i]] = 1;
    }
}

var topK = dict.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
return topK;
        }
}
