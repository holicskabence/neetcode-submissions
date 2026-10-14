public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        var nums1Set = new HashSet<int>();
        var nums2Set = new HashSet<int>();
        var result = new HashSet<int>();

        foreach(int num in nums1)
        {
            nums1Set.Add(num);
        }

        foreach(int num in nums2)
        {
            nums2Set.Add(num);
        }

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