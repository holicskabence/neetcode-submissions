public class TimeMap {
    private Dictionary<string, List<(string, int)>> store;

    public TimeMap() 
    {
        store = new Dictionary<string, List<(string, int)>>();
    }
    
    public void Set(string key, string value, int timestamp) 
    {
        if(store.ContainsKey(key))
        {
            store[key].Add((value, timestamp));
        }
        else
        {
            store[key] = new List<(string, int)> {(value, timestamp)};
        }
    }
    
    public string Get(string key, int timestamp) 
    {
        if(store.ContainsKey(key))
        {
            int low = 0;
            int high = store[key].Count - 1;
            string result = string.Empty;

            while(low <= high)
            {
                int middle = low + (high - low) / 2;

                if(store[key][middle].Item2 <= timestamp)
                {
                    result = store[key][middle].Item1;
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1;
                }
            }

            return result;
        }

        return string.Empty;
    }
}
