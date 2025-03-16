/* START: 23:09, END: 23:49
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

int LengthOfLongestSubstring(string s)
{
    if (s.Length < 2)
        return s.Length;
    int left = 0;
    int right = 1;
    string visited = "" + s[0];
    int maxLength = 0;
    while (right < s.Length)
    {
        char chr = s[right];
        while (visited.Contains(chr))
        {
            visited = visited.Substring(1);
            left++;
        }
        visited += chr;
        maxLength = Math.Max(maxLength, right - left + 1);
        right++;
    }
    return maxLength;
}

string param1;
int output;

param1 = "abcabcbb"; // "abc"
output = LengthOfLongestSubstring(param1);

param1 = "bbbbb"; // "b"
output = LengthOfLongestSubstring(param1);

param1 = "pwwkew"; // "wke"
output = LengthOfLongestSubstring(param1);

param1 = "dvdf"; // "vdf"
output = LengthOfLongestSubstring(param1);

int end = 0;
