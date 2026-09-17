public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var result = new int[m + n];

        int left = 0;
        int right = 0;
        int i = 0;
        while(m > left && n > right)
        {
            if(nums1[left] < nums2[right])
            {
                result[i] = nums1[left];
                left++;
            }
            else
            {
                result[i] = nums2[right];
                right++;
            }

            i++;
        }

        while(i < m + n)
        {
            if(m == left)
            {
                result[i] = nums2[right];
                right++;
            }
            else
            {
                result[i] = nums1[left];
                left++;
            }

            i++;
        }      

        for(int j = 0; j < nums1.Length; j++)
        {
            nums1[j] = result[j];
        }
    }
}