namespace Exercises.ArrayOrString
{
    public static class BestTimeToBuyAndSellStock2
    {
        public static int Solution(int[] prices)
        {
            int currentBuyPrice = int.MaxValue;
            int currentProfit = 0;
            int totalProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] - currentBuyPrice > currentProfit)
                {
                    currentProfit = prices[i] - currentBuyPrice;
                }
                else
                {
                    currentBuyPrice = prices[i];
                    totalProfit += currentProfit;
                    currentProfit = 0;
                }
            }

            return totalProfit += currentProfit;
        }
    }
}
