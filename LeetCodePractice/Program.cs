/*
START: 11:09, END: 11:47

*/

IList<string> SummaryRanges(int[] nums)
{
    List<string> list = new List<string>();
    if (nums.Length < 1)
        return list;

    int start = nums[0];
    int end = nums[0];

    for (int idx = 1; idx < nums.Length; idx++)
    {
        int num = nums[idx];
        if (num != end + 1)
        {
            if (start != end)
                list.Add($"{start}->{end}");
            else
                list.Add($"{start}");
            start = num;
        }
        end = num;
    }

    if (start != end)
        list.Add($"{start}->{end}");
    else
        list.Add($"{start}");

    return list;
}

int[] nums;
IList<string> output;
nums = [0, 1, 2, 4, 5, 7];
output = SummaryRanges(nums);

nums = [0, 2, 3, 4, 6, 8, 9];
output = SummaryRanges(nums);

int end = 0;