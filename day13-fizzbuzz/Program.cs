Console.WriteLine("Hello, Day13!");

for (int i = 1; i <= 100; i++)
{
    string result = "";
    if (i % 3 == 0) result += "Fizz";
    if (i % 5 == 0) result += "Buzz";
    Console.WriteLine(string.IsNullOrEmpty(result) ? i.ToString() : result);
}
