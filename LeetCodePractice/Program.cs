/* START: 21:35, END:   */

bool IsPalindrome(int x)
{
    string str = x.ToString();
    int left, right;
    left = 0;
    right = str.Length - 1;
    while (left <= right)
    {
        char chrLeft = str[left++];
        char chrRight = str[right--];
        if (chrLeft != chrRight)
            return false;
    }
    return true;
}

int param1;
bool output;

//  11
//   1
// 100
param1 = 121;
output = IsPalindrome(param1);

param1 = -121;
output = IsPalindrome(param1);

int end = 0;
