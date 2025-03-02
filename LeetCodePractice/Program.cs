/* START: 21:35, END:   */

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int i = nums1.Length - 1;
    m--; n--;
    while (n >= 0)
    {
        if (m >= 0 && nums1[m] > nums2[n])
        {
            nums1[i] = nums1[m];
            m--;
        }
        else
        {
            nums1[i] = nums2[n];
            n--;
        }
        i--;
    }
}

int[] param1;
int param2;
int[] param3;
int param4;
int output;

param1 = [1, 2, 3, 0, 0, 0];
param2 = 3;
param3 = [2, 5, 6];
param4 = 3;
Merge(param1, param2, param3, param4);

param1 = [1];
param2 = 1;
param3 = [];
param4 = 0;
Merge(param1, param2, param3, param4);

param1 = [0];
param2 = 0;
param3 = [1];
param4 = 1;
Merge(param1, param2, param3, param4);

int end = 0;
