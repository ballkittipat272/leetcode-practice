/* START: , END: 
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

int[] TwoSum(int[] numbers, int target)
{
    int left = 0, right = numbers.Length - 1;
    while (left < right)
    {
        int numLeft = numbers[left];
        int numRight = numbers[right];
        int sum = numLeft + numRight;
        if (sum == target)
            return [left + 1, right + 1];
        else if (sum < target)
            left++;
        else if (sum > target)
            right--;
    }
    return [0, 0];
}

int[] param1;
int param2;
int[] output;

param1 = [2, 7, 11, 15];
param2 = 9;
output = TwoSum(param1, param2); // [1,2]

param1 = [2, 3, 4];
param2 = 6;
output = TwoSum(param1, param2); // [1,3]

param1 = [-1, 0];
param2 = -1;
output = TwoSum(param1, param2); // [1,2]

param1 = [5, 25, 75];
param2 = 100;
output = TwoSum(param1, param2); // [1,2]

int end = 0;
