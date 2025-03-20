/* START: , END: 
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

int[] TwoSum(int[] numbers, int target)
{
    int index1 = 0, index2 = 1;
    while (index2 < numbers.Length)
    {
        int num1 = numbers[index1];
        int num2 = numbers[index2];
        int sum = num1 + num2;
        if (sum == target)
            return [index1 + 1, index2 + 1];
        if (index2 >= numbers.Length - 1)
        {
            index1++;
            if (index1 >= numbers.Length)
                break;
            index2 = index1;
        }
        index2++;
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
