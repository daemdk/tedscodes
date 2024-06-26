﻿// Day 3 - Finite State Machine (FSM)
// This time, we’ll model an order processing system using an FSM.
// This example demonstrates an FSM for order processing, showcasing a clean and clear implementation.

// The beauty of this code lies in:
// 1. Clear State Transition Methods: The ProcessOrder, ShipOrder, DeliverOrder, and CancelOrder methods are implemented clearly for each state. This readability makes the code beautiful.
// 2. Single Responsibility Principle: The Order class focuses solely on order state management, adhering to the single responsibility principle.
// 3. Effective Enum Usage: The OrderState enum concisely represents order states, enhancing code readability.

// Run command
// dotnet run

Console.WriteLine("Hello, Day3!");

var order = new Order();

order.ProcessOrder();
order.ShipOrder();
order.DeliverOrder();
order.CancelOrder();

Console.WriteLine($"Final order state: {order.State}");
