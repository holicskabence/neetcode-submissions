public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        var lefts = new int [length];
        var rights = new int [length];

        lefts[0] = 1;
        lefts[1] = nums[0];

        rights[length - 1] = 1;
        rights[length - 2] = nums[length - 1];

        for(int i = 2; i < length; i++){
           lefts[i] = lefts[i - 1] * nums[i - 1];
        }

        for(int i = length - 3; i >= 0; i--){
            rights[i] = rights[i + 1] * nums[i + 1];
        }

        var results = new int [length];
        for(int i = 0; i < length; i++){
            results[i] = lefts[i] * rights[i];
        }

        return results;
    }
}
