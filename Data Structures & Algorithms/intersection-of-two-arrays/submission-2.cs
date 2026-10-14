public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var nums1Set = new HashSet<int>(nums1);
        var nums2Set = new HashSet<int>(nums2);
        var result = new HashSet<int>();

        foreach(int num in nums1Set)
        {
            if(nums2Set.Contains(num))
            {
                result.Add(num);
            }
        }
        
        return result.ToArray();
    }
}