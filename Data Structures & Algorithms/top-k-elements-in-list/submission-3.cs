public class Solution {
public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Count() < k)
            {
                return new int[0];
            }

            var sorted = nums.ToList().OrderBy(x => x).ToList();
            var result = new int[k];
            result[0] = sorted[0];

            int counter = 1;
            int currentX = 0;
            int currentY = 1;
            for (int i = 1; i < sorted.Count(); i++)
            {
                if (sorted[i] == sorted[i - 1])
                {
                    counter++;
                }
                else
                {
                    if (counter >= k)
                    {
                        result[currentX] = sorted[i];
                        currentX++;
                    }

                    if (currentY < k)
                    {
                        result[currentY] = sorted[i];
                        currentY++;
                    }
                }
            }

            return result;
        }
}
