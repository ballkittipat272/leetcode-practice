/* START: , END: 
** RE-TRY: , END TRY: 
** RE-TRY 2: , END TRY 2: 
*/

string IntToRoman(int num)
{
    int start = num;
    string result = "";
    Dictionary<int, string> dict = new Dictionary<int, string>()
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
        {400, "CD"},
        {500, "D"},
        {900, "CM"},
        {1000, "M"},
    };

    foreach (int key in dict.Keys.OrderDescending())
    {
        int round = start / key;
        for (int i = 0; i < round; i++)
        {
            result += dict[key];
        }
        start = start % key;
        if (start == 0)
            break;
    }
    return result;
}

int param1;
string output;

param1 = 3749;
output = IntToRoman(param1); // "MMMDCCXLIX"

param1 = 58;
output = IntToRoman(param1); // "LVIII"

param1 = 1994;
output = IntToRoman(param1); // "MCMXCIV"

int end = 0;
