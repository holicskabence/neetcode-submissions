public class MyQueue {
    private Stack<int> stack;
    public MyQueue() {
        stack = new Stack<int>();
    }
    
    public void Push(int x) 
    {
        var tmp = new Stack<int>();
        tmp.Push(x);
        while(stack.Count > 0)
        {
            tmp.Push(stack.Pop());
        }

        stack = tmp;
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