// Day 4 - Prime Finder
//
// A prime number (or a prime) is a natural number greater than 1 that is not a product of two smaller natural numbers.
// The prime number finding algorithm has a significant impact on performance.
// Especially when looking for prime numbers in a large range, you need to choose an efficient algorithm.
// Use efficient algorithms like the Sieve of Eratosthenes.
//
// The beauty of this code lies in:
// 1. Application of the Sieve of Eratosthenes:
//    This code efficiently finds prime numbers using the Sieve of Eratosthenes algorithm.
//    It avoids redundant calculations and quickly identifies all prime numbers.
// 2. Effective Use of an Array:
//    The isPrime array is used to store whether a number is prime or not.
//    This approach minimizes duplicate computations.
// 3. Concise Looping:
//    The for loops are concise and enhance readability.
//    The code elegantly iterates through the numbers to identify primes.

using System.Diagnostics; // for Stopwatch

Console.WriteLine("Hello, Day4!");

Console.Write("Enter a positive integer: ");
if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{

    var primeFinder = new PrimeFinder();

    // single loop
    var stopwatch = Stopwatch.StartNew();
    var primes = primeFinder.FindPrimes(n);
    stopwatch.Stop();
    var timeTaken = stopwatch.Elapsed.TotalMilliseconds;

    foreach (var prime in primes)
    {
        Console.Write($"{prime} ");
    }

    Console.WriteLine($"Prime numbers up to {n}:");
    Console.WriteLine($"Single loop Time taken: {timeTaken} ms");

}
else
{
    Console.WriteLine("Invalid input. Please enter a positive integer.");
}
