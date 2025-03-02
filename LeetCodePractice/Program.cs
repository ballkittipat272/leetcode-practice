/* START: 19:40, END:   */

int SearchInsert(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int num = nums[i];
        if (target <= num)
            return i;
    }

    return nums.Length;
}

int[] param1;
int param2;
int output;

param1 = [1, 3, 5, 6];
param2 = 5;
output = SearchInsert(param1, param2);

param1 = [1, 3, 5, 6];
param2 = 2;
output = SearchInsert(param1, param2);

param1 = [1, 3, 5, 6];
param2 = 7;
output = SearchInsert(param1, param2);

int end = 0;
