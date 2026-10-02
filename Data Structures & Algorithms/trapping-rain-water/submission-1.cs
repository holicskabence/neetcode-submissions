public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int sum = 0;
        int current = 0;

        for(int i = 1; i < height.Length; i++)
        {
            if(height[left] <= height[i])
            {
                sum += current;
                current = 0;
                left = i;
            }
            else
            {
                current += height[left] - height[i];
            }
        }

        if(left != height.Length)
        {
            current = 0;
            for(int i = height.Length - 1; i > left; i--)
            {
                if(height[left] <= height[i])
                {
                    sum += current;
                    current = 0;
                    left = i;
                }
                else
                {
                    current += height[left] - height[i];
                }
            }
        }

        return sum;
    }
}
