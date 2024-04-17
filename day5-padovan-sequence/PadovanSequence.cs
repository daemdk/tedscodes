using System;
using System.Numerics;

class PadovanSequence
{
    public BigInteger Calculate(int n)
    {
        if (n == 0 || n == 1 || n == 2) return 1;

        BigInteger prevPrev = 1, prev = 1, current = 1, next;

        for (int i = 3; i <= n; i++)
        {
            next = prevPrev + prev;
            prevPrev = prev;
            prev = current;
            current = next;
        }

        return current;
    }
}
