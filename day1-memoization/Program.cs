Console.WriteLine("Hello Day1");

FibonacciCalculator calculator = new();
int term = 10;
long result = calculator.Calculate(term);
Console.WriteLine($"The results for {term}: {result}");

/// <summary>
/// Calculate a Fibonacci numbers
/// </summary>
class FibonacciCalculator
{

    // cache for memoization
    private Dictionary<int, long> _cache = new Dictionary<int, long>();

    /// <summary>
    /// Calculate the number
    /// </summary>
    /// <param name="n">numbers to calculate</param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public long Calculate(int n)
    {
        if (n < 0) throw new ArgumentException("n must be 0 or greater.");
        if (n <= 1) return n;

        // Returns if there is a cached value
        if (_cache.TryGetValue(n, out long value))
            return value;

        // The Calculate method calls itself to calculate Fibonacci numbers.
        // This makes the code concise, but can cause performance issues without memoization.
        value = Calculate(n - 1) + Calculate(n - 2);
        _cache[n] = value; // Store results in cache
        return value;
    }
}