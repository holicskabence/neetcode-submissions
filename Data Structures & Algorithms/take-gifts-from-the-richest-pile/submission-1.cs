public class Solution {
    public long PickGifts(int[] gifts, int k) {
        var queue = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );

        foreach(var gift in gifts){
            queue.Enqueue(gift, gift);
        }

        while(k > 0){
            int current = queue.Dequeue();
            current = (int)Math.Sqrt(current);
            queue.Enqueue(current, current);
            k--;
        }

        long sum = 0;
        while(queue.Count > 0){
            sum += queue.Dequeue();
        }

        return sum;
    }
}