# Day 11 - Factory Method Pattern

The **Factory Method Design Pattern** is a creational pattern that allows objects to be created without tightly coupling the object creation code to the client code. It defines an interface for creating objects in a superclass but lets subclasses decide which class to instantiate. Here's a breakdown:

## **Difference Between Factory Pattern and Factory Method Pattern:**
   Let's start by acknowledging that Factory Pattern and Factory Method Pattern are different. Although both are related to object creation, they serve distinct purposes and have different structures.

### **Factory Design Pattern (Simple Factory Pattern)**
* **Purpose**: Encapsulates the process of object creation, separating client code from the object creation code.
* **Structure**:
    * **Factory**: A class responsible for creating objects. It provides methods to return objects to the client.
    * **Product**: An abstract class or interface representing the type of objects being created. Concrete objects implement this interface.
    * **ConcreteProduct**: The actual objects being created. The Factory creates and returns these objects.
* **Example Usage**: For instance, you can create a Factory that produces different types of shapes. The Factory can return circles, rectangles, or triangles to the client.

### **Factory Method Design Pattern**
* **Purpose**: Defers object creation to subclasses. The superclass defines an interface for creating objects, and subclasses implement this interface to create objects.
* **Structure**:
    * **Creator (Abstract Creator)**: An abstract class or interface responsible for creating objects. It declares the factory method.
    * **ConcreteCreator**: The class that actually creates objects. It implements the factory method to return objects.
    * **Product**: An abstract class or interface representing the type of objects being created. Concrete objects implement this interface.
* **Example Usage**: The credit card example described in this project is an instance of the Factory Method Design Pattern. Each credit card type has a corresponding Factory, and the Factory method creates the specific credit card.
