public class Solution {
    public int[] SortArray(int[] nums) {
        var queue = new PriorityQueue<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], nums[i]);
        }

        var result = new int[queue.Count];
        int j = 0;
        while(queue.Count > 0)
        {
            result[j] = queue.Dequeue();
            j++;
        }

        return result;
    }
}