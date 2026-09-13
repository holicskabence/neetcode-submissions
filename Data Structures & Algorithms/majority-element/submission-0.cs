public class Solution {
    public int MajorityElement(int[] nums) {
        var ordered = nums.OrderBy(x => x).ToList();
        int current = 1;

        for(int i = 1; i < ordered.Count; i++)
        {
            if(ordered[i]!= ordered[i - 1])
            {
                bool isMajority = current > ordered.Count / 2;
                if(isMajority)
                {
                    return ordered[i - 1];
                }
                
                current = 1;
            }
            else
            {
                current++;
            }
        }

        return  current > ordered.Count / 2 ? ordered[ordered.Count -1] : -1;
    }
}