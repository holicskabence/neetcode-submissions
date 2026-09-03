public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var queue = new PriorityQueue<int, int>();
        foreach(var num in nums){
            queue.Enqueue(num, num);
        }

        int count = queue.Count;
        while(count > k){
            queue.Dequeue();
            count--;
        }

        return queue.Dequeue();;
    }
}
