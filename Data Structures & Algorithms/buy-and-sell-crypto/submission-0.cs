public class Solution {
    public int MaxProfit(int[] prices) {
        int currentMin = 999;
        int maxProfit = 0;

        for(int i = 0; i < prices.Length; i++){
            if(currentMin > prices[i]){
                currentMin = prices[i];
            }

            int profit = prices[i] - currentMin;

            if(profit > maxProfit){
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}
