public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0;
        int r = 1;
        int maxProfit = 0;
        while (r < prices.Length) {
           int profit = prices[r] - prices[l];
           maxProfit = Math.Max(maxProfit, profit);
           if(prices[r] < prices[l]) {
            l = r;
           }
           r++;
        }
        return maxProfit;
    }
}
