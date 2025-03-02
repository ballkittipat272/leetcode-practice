/*
START: , END: , STOP: 


*/

bool WordPattern(string pattern, string s)
{
    string[] splittedWords = s.Split(' ');

    if (pattern.Length != splittedWords.Length)
    {
        return false;
    }

    Dictionary<char, string> dict = new Dictionary<char, string>();

    int idx = 0;
    while (idx < pattern.Length)
    {
        char chr = pattern[idx];
        string word = splittedWords[idx];

        if (dict.TryGetValue(chr, out string? value))
        {
            if (value != word)
                return false;
        }
        else
        {
            if (dict.ContainsValue(word))
            {
                return false;
            }
            dict.Add(chr, word);
        }

        idx++;
    }
    return true;
}

string pattern, s;
bool ans;
pattern = "abba";
s = "dog cat cat fish";

ans = WordPattern(pattern, s);


int end = 0;