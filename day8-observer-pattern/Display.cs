class Display : IObserver
{
    public void Update(int temperature)
    {
        Console.WriteLine($"Current temperature: {temperature}°C");
    }
}