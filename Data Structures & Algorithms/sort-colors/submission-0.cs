public class Solution {
    public void SortColors(int[] nums) {
        var colors = new int[3];
        for(int i = 0; i < nums.Length; i++)
        {
            colors[nums[i]]++;
        }

        int counter = 0;
        for(int j = 0; j < colors.Length; j++)
        {
            while(colors[j] != 0)
            {
                nums[counter] = j;
                colors[j]--;
                counter++;
            }
        }
    }
}