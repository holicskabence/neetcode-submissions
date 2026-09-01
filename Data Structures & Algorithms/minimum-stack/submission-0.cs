public class MinStack {
    private List<int> CurrentStack;
    private List<int> MinValStack;
    public MinStack() {
        CurrentStack = new List<int>();
        MinValStack = new List<int>();
    }
    
    public void Push(int val) {
        CurrentStack.Add(val);
        int minIndex = MinValStack.Count - 1;
        if(minIndex > -1 && MinValStack[minIndex] < val)
        {
            MinValStack.Add(MinValStack[minIndex]);
        }
        else
        {
           MinValStack.Add(val);
        }
    }
    
    public void Pop() {
        int index = CurrentStack.Count - 1;
        if(index > -1){
            CurrentStack.RemoveAt(index);
            MinValStack.RemoveAt(index);
        }
    }
    
    public int Top() {
        return CurrentStack.Count > 0 ? CurrentStack[CurrentStack.Count - 1] : 0;
    }
    
    public int GetMin() {
        return MinValStack.Count > 0 ? MinValStack[MinValStack.Count - 1] : 0;
    }
}
