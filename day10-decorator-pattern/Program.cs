//******************************************************************
// Day 10 - Decorator Pattern
// Decorator Pattern is a structural design pattern that allows you to dynamically add new functionality to an object without altering its structure. It provides a flexible way to extend the behavior of existing classes without modifying them directly.

// The key components of the Decorator Pattern
// 1. Component: This defines the interface or abstract class for objects that can perform certain operations. It represents the target object that we want to enhance with additional features.
// 2. ConcreteComponent: This is the actual class that implements the Component interface. It provides the basic functionality.
// 3. Decorator: This implements the Component interface and holds a reference to a Component object. It adds new behavior by wrapping the original object.
// 4. ConcreteDecorator: This extends the Decorator class and adds specific features or modifications.

// For example, let’s consider a simple text messaging object that can display plain text. Now, if we want to add HTML tags, encryption, or network transmission to this message, we can create separate decorators for each feature. These decorators can be combined to enhance the original message object as needed.

// The Decorator Pattern is especially useful in languages like JavaScript (which uses prototypes) and provides flexibility in design even in class-based languages like C#. It allows us to extend object functionality dynamically, particularly when we need to add or modify features at runtime.
//
// Advantages of the Decorator Pattern:
// 1. Adds new functionality without altering existing code.
// 2. Allows composition of multiple decorators for complex features.
// 3. Provides more flexibility than inheritance.
//
// Drawbacks:
// 1. Can lead to a large number of small objects, increasing system complexity.
// 2. Understanding relationships between components and decorators can be challenging.
//
// Summary
// Considering these pros and cons, the Decorator Pattern is best suited for situations where dynamic extension or modification of object behavior is necessary.
//
//******************************************************************

Console.WriteLine("Hello, Day 10!");

// basic circle object
IShape circle = new Circle();

// Circle object decorated in red
IShape redCircle = new RedShapeDecorator(new Circle());

// Drawing a basic circle
circle.Draw();

// Drawing a circle decorated in red
redCircle.Draw();
