public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int x = 0;
        int y = numbers.Length - 1;

        while(true){
            int current = numbers[x] + numbers[y];

            if(current == target){
                return new int[] { x + 1, y + 1 };
            }

            if(current < target){
                x++;
            }else{
                y--;
            }
        }
    }
}
