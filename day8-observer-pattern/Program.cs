// Day 8 - Observer Pattern
// The Observer pattern defines one-to-many dependencies between objects.
// This pattern ensures that when the state of one object changes, all other objects that depend on that object are automatically notified and updated.
// This pattern is widely used when implementing distributed event processing systems.

// The Observer pattern has the following main components:
// * Subject: A subject maintains a list of observers and automatically notifies registered observers when its status changes.
// * Observer: An observer detects and reacts to changes in the subject's state. It is registered with the subject and implements methods that are called when the subject changes state.

// Code Description
// In the code, WeatherStation acts as a Subject, and Display acts as an Observer.
// Notify the observer when the temperature changes by calling the SetTemperature method. This example is simple, but demonstrates the basic concepts of the Observer pattern. In practice, it is utilized in more complex scenarios12.

Console.WriteLine("Hello, Day 8!");

var weatherStation = new WeatherStation();
var display = new Display();

weatherStation.RegisterObserver(display);

// Notifies observers when temperature changes
weatherStation.SetTemperature(25);
