/*
START: 15:12, END: 15:50
Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

------------------------------------------------------------

[1,2,3,4,5,6,7], 3 -> [5,6,7,......]


3, 7
8, 7 -> 1, 7

*/

using System.Xml.Linq;

void Rotate(int[] nums, int k)
{
    int r = k;
    if (k > nums.Length)
        r = k % nums.Length;

    int j = 0;
    int[] elements = new int[r];
    int start = nums.Length - r;

    for (int i = start; i < nums.Length; i++)
    {
        int t = nums[i];
        elements[j++] = t;
    }


    j = 0;
    int[] news = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        if (i < elements.Length)
        {
            news[i] = elements[i];
        }
        else
        {
            news[i] = nums[j++];
        }
    }

    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = news[i];
    }
}


// case 1
int[] nums = [1, 2, 3, 4, 5, 6, 7];
int k = 3;
//Rotate(nums, k);


// case 2 [-1], 2
int[] nums1 = [-1];
int k1 = 2;
Rotate(nums1, k1);