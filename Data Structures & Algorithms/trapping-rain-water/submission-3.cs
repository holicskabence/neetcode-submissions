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

        Console.WriteLine(left);

        if(left != height.Length - 1)
        {
            current = 0;
            int right = height.Length - 1;
            
            for(int i = right; i > left; i--)
            {
                if(height[right] >= height[i])
                {
                    sum += current;
                    current = 0;
                    right = i;
                }
                else
                {
                    current += height[i] - height[right];
                }
            }
        }

        return sum;
    }
}