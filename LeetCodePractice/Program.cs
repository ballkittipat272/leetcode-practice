/* START: 13:48, END:   */

bool IsValid(string s)
{
    Dictionary<char, char> matchBrackets = new Dictionary<char, char>()
    {
        {')', '('},
        {']', '['},
        {'}', '{'},
    };
    char[] closeBrackets = [')', ']', '}'];


    string keep = "";
    for (int idx = 0; idx < s.Length; idx++)
    {
        char chr = s[idx];
        if (closeBrackets.Contains(chr))
        {
            if (keep == "") return false;
            char lastKeep = keep[keep.Length - 1];
            if (lastKeep != matchBrackets[chr])
            {
                return false;
            }
            keep = keep.Substring(0, keep.Length - 1);
            continue;
        }

        keep += chr;
    }

    return keep == "";
}


string param1;
bool output;

// param1 = "()";
// output = IsValid(param1);

// param1 = "()[]{}";
// output = IsValid(param1);

// param1 = "(]";
// output = IsValid(param1);

// param1 = "([])";
// output = IsValid(param1);

param1 = "]";
output = IsValid(param1);

int end = 0;
