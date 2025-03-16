/* START: 23:09, END: 23:49
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

string LengthOfLongestSubstring(string s)
{
    if (s.Length < 2)
        return s;
    int left = 0;
    int right = 1;
    string visited = "" + s[0];
    int maxLength = 0;
    string maxWord = "";
    while (right < s.Length)
    {
        char chr = s[right];
        while (visited.Contains(chr))
        {
            visited = visited.Substring(1);
            left++;
        }
        visited += chr;
        if (right - left + 1 > maxLength)
        {
            maxLength = Math.Max(maxLength, right - left + 1);
            maxWord = s.Substring(left, maxLength);
        }
        right++;
    }
    return maxWord;
}

string param1;
string output;

param1 = "xxxxaxabcdexxabcxx"; // "xabcde"
output = LengthOfLongestSubstring(param1);

param1 = "xxxxaxabcdexyz1234xabcxx"; // "abcdexyz1234"
output = LengthOfLongestSubstring(param1);

int end = 0;
