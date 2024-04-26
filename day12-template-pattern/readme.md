# Day 12 - Template Pattern

The Template Method Design Pattern is a behavioral pattern that defines the skeleton of an algorithm in a base class and allows subclasses to override specific steps without changing the overall algorithm’s structure. Let’s dive into an example to understand it better.

Suppose we’re building different types of houses (e.g., concrete, wooden, glass). Regardless of the material, the construction process follows a sequence of steps: foundation, pillars, walls, and windows. The order remains the same, but the materials and details differ.

# Code Explain
1. Create an abstract class called HouseTemplate:
2. Concrete subclasses (e.g., ConcreteHouse, WoodenHouse, GlassHouse) extend HouseTemplate and provide specific implementations for each step:
