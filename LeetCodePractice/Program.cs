/* START: 21:35, END:   */

string AddBinary(string a, string b)
{
    string result = "";
    int diff = Math.Abs(a.Length - b.Length);
    if (a.Length < b.Length)
    {
        a = a.PadLeft(a.Length + diff);
    }
    else
    {
        b = b.PadLeft(b.Length + diff);
    }

    bool hasSurplus = false;
    for (int i = a.Length - 1; i >= 0; i--)
    {
        int intA = 0;
        int intB = 0;

        if (i <= a.Length - 1)
            intA = a[i] == '1' ? 1 : 0;
        if (i <= b.Length - 1)
            intB = b[i] == '1' ? 1 : 0;

        int sum = intA + intB;
        if (hasSurplus)
        {
            sum += 1;
        }
        hasSurplus = sum > 1;

        int mod = sum % 2;
        result = mod.ToString() + result;
    }

    if (hasSurplus)
        result = '1' + result;

    return result;
}

string param1;
string param2;
string output;

//  11
//   1
// 100
param1 = "11";
param2 = "1";
output = AddBinary(param1, param2);

param1 = "1010";
param2 = "1011";
output = AddBinary(param1, param2);

int end = 0;
