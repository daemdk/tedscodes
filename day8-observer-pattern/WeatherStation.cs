class WeatherStation : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private int temperature;

    public void SetTemperature(int temp)
    {
        temperature = temp;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }
}