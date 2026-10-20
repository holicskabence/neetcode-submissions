public class MyQueue {
    private Stack<int> stack;
    public MyQueue() {
        stack = new Stack<int>();
    }
    
    public void Push(int x) 
    {
        var tmp = new List<int>();
        while(stack.Count > 0)
        {
            tmp.Add(stack.Pop());
        }

        tmp.Add(x);
        for(int i = tmp.Count - 1; i >= 0; i--)
        {
            stack.Push(tmp[i]);
        }
    }
    
    public int Pop() 
    {
        return stack.Pop();
    }
    
    public int Peek() 
    {
        return stack.Peek();
    }
    
    public bool Empty() 
    {
        return stack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */