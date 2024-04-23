// Day 9 - Adapter Pattern

// The Adapter Pattern is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge between two incompatible interfaces. This pattern is particularly useful when you want to use existing classes, but their interfaces do not match the one you need.
// In the code, the Client class expects to work with the ITarget interface. However, the Adaptee class has a different interface. The Adapter class implements the ITarget interface and wraps an Adaptee object, translating the Adaptee’s methods into the ITarget interface. Thus, the client can use the Adaptee’s functionality through the Adapter.
// The Adapter Pattern is often used when integrating new systems with existing ones or when using libraries and frameworks without altering the existing code. It enhances system flexibility and promotes code reusability.

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Day 9!");

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible.");
Console.WriteLine("But with adapter client can call it's method.");
Console.WriteLine(target.GetRequest());
