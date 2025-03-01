/*
START: 20:35, END: , STOP: 21:20


*/

bool CanConstruct(string ransomNote, string magazine)
{
    int rIdx, nIdx;
    rIdx = 0;
    nIdx = 0;
    List<int> usedIdxs = new List<int>();

    while (rIdx < ransomNote.Length)
    {
        char rChrctr = ransomNote[rIdx++];

        bool match = false;
        while (nIdx < magazine.Length)
        {
            if (!usedIdxs.Contains(nIdx))
            {
                char nChrctr = magazine[nIdx];
                if (rChrctr == nChrctr)
                {
                    usedIdxs.Add(nIdx);
                    match = true;
                    nIdx++;
                    break;
                }
            }
            nIdx++;
        }

        if (match)
        {
            nIdx = 0;
            continue;
        }
        return false;
    }
    return true;
}


string s, t;
bool yes;
s = "aa";
t = "ab";

yes = CanConstruct(s, t);


int end = 0;