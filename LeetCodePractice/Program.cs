/* START: 21:35, END:   */

int ClimbStairs(int n)
{
    int[] mem = new int[n + 1];
    return Climb(n, mem);
}

int Climb(int n, int[] mem)
{
    if (n <= 2)
        return n;
    if (mem[n] != 0)
        return mem[n];
    mem[n] = Climb(n - 1, mem) + Climb(n - 2, mem);
    return mem[n];
}

int param1;
int output;

param1 = 2;
output = ClimbStairs(param1);

param1 = 3;
output = ClimbStairs(param1);

int end = 0;
