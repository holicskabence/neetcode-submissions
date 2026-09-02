public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var result = new int[temperatures.Length];
        var notFound = new Stack<(int index, int temp)>();

        for (int i = 0; i < temperatures.Length; i++) 
        {
            int temperature = temperatures[i];
            
            if(notFound.Count > 0)
            {
                var last = notFound.Peek();

                while(last.temp < temperature && notFound.Count > 0)
                {
                    result[last.index] = i - last.index;
                    notFound.Pop();

                    if(notFound.Count > 0)
                    {
                        last = notFound.Peek();
                    }
                }
            }
            
            notFound.Push((i, temperature));
        }

        return result;
    }
}
