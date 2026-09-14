public class MedianFinder {
    private int Sum;
    private int Counter;
    public MedianFinder() {
        
    }
    
    public void AddNum(int num) 
    {
        Sum += num;
        Counter++;
    }
    
    public double FindMedian() 
    {
        return (double)Sum / Counter;
    }
}
