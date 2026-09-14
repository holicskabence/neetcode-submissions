public class KthLargest 
{
    private PriorityQueue<int, int> MainQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    private int K;
    public KthLargest(int k, int[] nums) 
    {
        K = k;
        for(int i = 0; i < nums.Length; i++)
        {
            MainQueue.Enqueue(nums[i], nums[i]);
        }
    }
    
    public int Add(int val)
    {
        var queue = new Queue<int>();
        MainQueue.Enqueue(val, val);

        int i = 0;
        while(i < K && MainQueue.Count > 0)
        {
            queue.Enqueue(MainQueue.Dequeue());
            i++;
        }

        int result = queue.Last();

        while(queue.Count > 0)
        {
            int current = queue.Dequeue();
            MainQueue.Enqueue(current, current);
        }

        return result;
    }
}
