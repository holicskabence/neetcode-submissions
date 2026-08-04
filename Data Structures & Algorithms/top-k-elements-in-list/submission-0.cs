public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var sorted = nums.OrderBy(x => x).ToList();
        var result = new List<int>();

        int counter = 1;
        int current = sorted[0];
        for(int i = 1; i < sorted.Count(); i++){
            if(current == sorted[i])
            {
                counter++;
            }
            else
            {
                if(counter >= k)
                {
                    result.Add(current);
                }

                counter = 0;
                current = sorted[i];
            }
        }

        return result.ToArray();
    }
}
