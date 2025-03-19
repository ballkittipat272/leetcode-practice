/* START: , END: 
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

int MaxProfit(int[] prices)
{
    if (prices.Length < 2)
        return 0;
    int buy = 0, sell = 1;
    int profit = 0;
    while (sell < prices.Length)
    {
        int buyPrice = prices[buy];
        int sellPrice = prices[sell];
        if (buyPrice < sellPrice)
        {
            profit += sellPrice - buyPrice;
        }
        buy = sell;
        sell++;
    }
    return profit;
}

int[] param1;
int output;

param1 = [7, 1, 5, 3, 6, 4];
output = MaxProfit(param1); // 7

param1 = [1, 2, 3, 4, 5];
output = MaxProfit(param1); // 4

param1 = [7, 6, 4, 3, 1];
output = MaxProfit(param1); // 0

int end = 0;
