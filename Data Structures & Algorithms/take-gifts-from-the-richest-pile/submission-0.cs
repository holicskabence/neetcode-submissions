public class Solution {
    public long PickGifts(int[] gifts, int k) {
        var queue = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );

        foreach(var gift in gifts){
            queue.Enqueue(gift, gift);
        }

        int i = 0;
        while(i < 4){
            int current = queue.Dequeue();
            current = (int)Math.Round(Math.Sqrt(current), 0);
            queue.Enqueue(current, current);
            i++;
        }

        long sum = 0;
        while(queue.Count > 0){
            sum += queue.Dequeue();
        }

        return sum;
    }
}