/* START: 22:40, END: 23:18
** RE-TRY: 23:20, END TRY: 23:25
*/

int MaxProfit(int[] prices)
{
    int minPrice = int.MaxValue;
    int maxProfit = 0;
    
    foreach (var price in prices)
    {
        minPrice = Math.Min(minPrice, price);
        maxProfit = Math.Max(maxProfit, price - minPrice);
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

param1 = [2,1,2,1,0,1,2]; // 2
output = MaxProfit(param1);

int end = 0;
