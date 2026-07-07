public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        int length = nums.Length;
        var result = new List<List<int>>();
        var sorted = nums.ToList().OrderBy(x => x).ToArray(); 

        for(int i = 0; i < length; i++){
            if(i > 0 && sorted[i] == sorted[i-1]){
                continue;
            }

            int left = i + 1;
            int right = length - 1;

            while(left < right){
                int currentSum = sorted[i] + sorted[left] + sorted[right];

                if(currentSum < 0){
                    left++;
                }
                else if(currentSum > 0)
                {
                    right--;
                }
                else
                {
                    result.Add(new List<int>(){sorted[i] , sorted[left] , sorted[right]});
                    left++;
                    right--;

                    while(left < right && sorted[left] == sorted[left - 1]){
                        left++;
                    }

                    while(left < right && sorted[right] == sorted[right + 1]){
                        right--;
                    }
                }
            }
        }
        return result;
    }
}
