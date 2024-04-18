// Day 6 - Builder Pattern

// The Builder pattern is a design pattern that allows you
// to build complex objects step by step.
// Below is optimized example code for building a computer object
// using the builder pattern.

// The beauty of this code lies in
// 1. Method Chaining: Methods such as WithCPU
//                     and WithRAM return ComputerBuilder instances,
//                     allowing methods to be called in chain.
//                     This makes the code more readable and easier to use.
// 2. Flexibility: Clients can build objects by selecting only the components they need,
//                 leaving the rest default or unselected.
// 3. Extensibility: Adding new components or making changes is simple.
//                   For example, if you want to add a new memory type or storage device,
//                   simply add a new method to the ComputerBuilder class.

Console.WriteLine("Hello, Day6!");

var computer = new ComputerBuilder()
    .SetCPU("Intel Core i9")
    .SetRAM("32GB")
    .SetStorage("2TB NVMe SSD")
    .SetGraphicsCard("NVIDIA RTX 3090")
    .Build();

Console.WriteLine(computer);
