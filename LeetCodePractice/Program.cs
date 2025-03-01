/*
START: 20:35, END: , STOP: 21:20


*/

bool IsIsomorphic(string s, string t)
{
    if (s.Length != t.Length)
        return false;

    HashSet<char> hsS = new HashSet<char>();
    HashSet<char> hsT = new HashSet<char>();
    Dictionary<char, char> dict = [];
    int idx = 0;

    while (idx < s.Length)
    {
        char charS = s[idx];
        char charT = t[idx];
        hsS.Add(charS);
        hsT.Add(charT);

        if (dict.ContainsKey(charS))
        {
            if (dict[charS] != charT)
                return false;
        }
        else
        {
            dict.Add(charS, charT);
        }

        idx++;
    }

    return hsS.Count == hsT.Count;
}


string s, t;
bool yes;
s = "badc";
t = "baba";

yes = IsIsomorphic(s, t);


int end = 0;