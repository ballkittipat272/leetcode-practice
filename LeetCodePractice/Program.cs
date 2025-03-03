/* START: 22:40, END: 23:18
** RE-TRY: 23:20, END TRY: 23:25
** RE-TRY 2: 23:26, END TRY 2: 23:28
*/

int MaxProfit(int[] prices)
{
    if (prices.Length < 2) return 0;
    int maxProfit = 0;
    int minPrice = prices[0];
    for (int i = 1; i < prices.Length; i++)
    {
        if (minPrice > prices[i])
            minPrice = prices[i];
        int profit = prices[i] - minPrice;
        if (maxProfit < profit)
            maxProfit = profit;
    }
    return maxProfit;
}

int[] param1;
int param2;
int[] param3;
int param4;
int output;

param1 = [7, 1, 5, 3, 6, 4]; // 5
output = MaxProfit(param1);

param1 = [7, 6, 4, 3, 1]; // 0
output = MaxProfit(param1);

param1 = [2, 1, 2, 1, 0, 1, 2]; // 2
output = MaxProfit(param1);

int end = 0;
