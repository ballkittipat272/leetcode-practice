/* START: , END: 
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

int MinSubArrayLen(int target, int[] nums)
{
    int left, right, sum, minLength;
    left = right = sum = minLength = 0;
    while (left < nums.Length && right < nums.Length)
    {
        sum += nums[right];
        if (sum >= target)
        {
            if (minLength > right - left + 1 || minLength == 0)
                minLength = right - left + 1;
            sum -= nums[left];
            sum -= nums[right];
            left++;
        }
        else
            right++;
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
