public class Solution {
    public int MaxProfit(int[] prices) {
        int maxPr = 0;
        int minPrice = prices[0];
        for(int i = 1; i < prices.Length; i++){
            if(prices[i] < minPrice) {
                minPrice = prices[i];
                continue;
            }
            int dayProfit = prices[i] - minPrice;
            maxPr = Math.Max(dayProfit, maxPr);
        }
        return maxPr;
    }
}
