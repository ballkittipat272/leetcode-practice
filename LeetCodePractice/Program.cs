/* START: 23:39, END: 00:11
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 

num = 1; i = 0; 
num = 1; i = 0; 
num = 1; i = 1; 
num = 2; i = 2; 

*/

int RemoveDuplicates(int[] nums)
{
    int j = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        int num = nums[i];
        if (j < 2 || num != nums[j - 2])
        {
            nums[j] = num;
            j++;
        }
    }
    return j;
}

int[] param1;
int param2;
int[] param3;
int param4;
int output;

param1 = [1, 1, 1, 2, 2, 3];
output = RemoveDuplicates(param1);

param1 = [0, 0, 1, 1, 1, 1, 2, 3, 3];
output = RemoveDuplicates(param1);

int end = 0;
