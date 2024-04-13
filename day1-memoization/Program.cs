Console.WriteLine("Hello Day1");

FibonacciCalculator calculator = new();
int term = 10;
long result = calculator.Calculate(term);
Console.WriteLine($"The results for {term}: {result}");
