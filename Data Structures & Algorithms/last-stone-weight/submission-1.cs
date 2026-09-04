public class Solution {
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>(
            Comparer<int>.Create((a,b) => b.CompareTo(a))
        );

        foreach(var stone in stones){
            queue.Enqueue(stone, stone);
        }

        while(queue.Count > 1){
            int y = queue.Dequeue();
            int x = queue.Dequeue();

            if(x < y){
                int weight = y - x;
                queue.Enqueue(weight, weight);
            }
        }

        return queue.Count > 0 ? queue.Dequeue() : 0;
    }
}
