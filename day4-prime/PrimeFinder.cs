public class PrimeFinder
{
    public List<int> FindPrimes(int n)
    {
        // Numbers less than 1 are not prime numbers
        if (n <= 1)
        {
            return new List<int>();
        }

        // Assume all numbers are prime numbers.
        var isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        // exclude multiples of p from prime numbers
        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        // add only prime numbers to list
        var primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }

}
