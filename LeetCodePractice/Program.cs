/*
START: 20:35, END: , STOP: 21:20


*/

bool IsPalindrome(string s)
{
    if (s == null) return false;
    s = s.ToLower().Trim();

    int left, right;
    left = 0;
    right = s.Length - 1;

    while (left < right)
    {
        if (!Char.IsLetterOrDigit(s[left]))
        {
            left++;
            continue;
        }
        if (!Char.IsLetterOrDigit(s[right]))
        {
            right--;
            continue;
        }

        if (s[left] != s[right])
            return false;
        left++;
        right--;
    }

    return true;
}


string s;
bool isPalindrome;

s = "A man, a plan, a canal: Panama";
isPalindrome = IsPalindrome(s);

s = "race a car";
isPalindrome = IsPalindrome(s);

s = " ";
isPalindrome = IsPalindrome(s);

int end = 0;
