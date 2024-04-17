// Day 5 - Padovan Sequence

// A Padovan sequence is a sequence where each term is the sum of the previous two terms,
// and each term follows the formula P(n) = P(n-2) + P(n-3).
// Here's a beautifully written example of how to implement this in C#,
// optimizing the performance of code

// The beauty of this code lies in:
// 1. Simplicity: The code does only what it needs to do and is free of unnecessary complexity.
// 2. Efficiency: Use loops instead of recursion to reduce call stack overhead, and use BigIntegers to handle large numbers.
// 3. Scalability: By using BigInteger, we can calculate the terms of even very large sequences.

using System.Diagnostics; // for Stopwatch

Console.WriteLine("Hello, Day5!");

Console.Write("Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{

    PadovanSequence padovan = new();

    var stopwatch = Stopwatch.StartNew();
    var result = padovan.Calculate(n);
    stopwatch.Stop();

    Console.WriteLine($"Time taken: {stopwatch.Elapsed.TotalMilliseconds} ms");
    Console.WriteLine($"The {n}th term of the Padovan Sequence is {result}");

}
else
{
    Console.WriteLine("Invalid input. Please enter a number.");
}
