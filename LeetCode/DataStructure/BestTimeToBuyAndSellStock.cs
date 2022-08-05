using System.Collections;

namespace LeetCode.DataStructure
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            // here inside the single loop we are updating the max Profit and minimum selling price.
            int minPrice = prices[0];
            int maxProfit = int.MinValue;
            for(int i = 0; i<prices.Length; i++)
            {
                int profit = prices[i] - minPrice;
                if(profit>maxProfit) maxProfit = profit;
                if (prices[i]<minPrice) minPrice= prices[i];
            }
            return maxProfit;
        }
    }
}
