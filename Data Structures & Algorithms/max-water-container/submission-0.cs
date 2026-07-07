public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;
        
        while(left < right){
            int width = right - left;
            int currentMin = Math.Min(heights[left], heights[right]);
            int currentArea = currentMin * width;
            maxArea = Math.Max(maxArea, currentArea);

            if(heights[left] < heights[right]){
                left++;
            }else{
                right--;
            }
        }

        return maxArea;
    }
}
