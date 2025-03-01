/*
START: 16:44, END: , STOP: 17:32
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.

------------------------------------------------------------

flower
flow
flight



*/

string LongestCommonPrefix(string[] strs)
{
    int i = 0;
    int r = 1;
    string word = "";
    for (int w = 0; w < strs.Length; w++)
    {
        string str = strs[w];
        if (r > 1 && i >= str.Length)
        {
            break;
        }
        if (w == 0 && i < str.Length)
        {
            char c = str[i++];
            word += c;
            continue;
        }
        else if (!str.StartsWith(word))
        {
            word = word.Substring(0, word.Length - 1);
            break;
        }
        else if (w >= strs.Length - 1)
        {
            // word = word;
            w = -1;
            r++;
        }
    }

    return word;
}

string pfx;
string[] strs;
strs = ["flower", "flow", "flight"];
pfx = LongestCommonPrefix(strs);

strs = ["dog", "racecar", "car"];
pfx = LongestCommonPrefix(strs);

strs = ["a"];
pfx = LongestCommonPrefix(strs);

strs = ["a","b"];
pfx = LongestCommonPrefix(strs);

strs = [""];
pfx = LongestCommonPrefix(strs);


int end = 0;