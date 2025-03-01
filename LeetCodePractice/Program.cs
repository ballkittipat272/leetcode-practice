/*
START: 20:35, END: , STOP: 21:20


*/

bool IsSubsequence(string s, string t)
{
    if (s == t) return true;

    int j = 0;
    for (int i = 0; i < s.Length; i++)
    {
        char charctr = s[i];

        bool match = false;
        while (j < t.Length)
        {
            char c = t[j++];
            if (charctr == c)
            {
                match = true;
                break;
            }
        }
        if (match)
            continue;

        return false;
    }

    return true;
}


string s, t;
bool yes;
s = "abc";
t = "ahbgdc";

yes = IsSubsequence(s, t);


int end = 0;