/* START: , END: 
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

int MinSubArrayLen(int target, int[] nums)
{
    int left = 0;
    int sum = 0;
    int length = 0;
    int minLength = 0;
    for (int i = left; i < nums.Length && left < nums.Length; i++)
    {
        sum += nums[i];
        length++;
        if (sum >= target)
        {
            if (minLength == 0 || length < minLength)
                minLength = length;
            sum = 0;
            length = 0;
            left++;
            i = left - 1;
        }
    }
    return minLength;
}

int param1;
int[] param2;
int output;

param1 = 7;
param2 = [2, 3, 1, 2, 4, 3];
output = MinSubArrayLen(param1, param2);

param1 = 4;
param2 = [1, 4, 4];
output = MinSubArrayLen(param1, param2);

param1 = 11;
param2 = [1, 1, 1, 1, 1, 1, 1, 1];
output = MinSubArrayLen(param1, param2);

int end = 0;
