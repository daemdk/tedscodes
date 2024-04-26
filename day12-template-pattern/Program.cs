
Console.WriteLine("Hello, Day 12!");

HouseTemplate concreteHouse = new ConcreteHouse();
concreteHouse.BuildHouse();

Console.WriteLine();

HouseTemplate woodenHouse = new WoodenHouse();
woodenHouse.BuildHouse();
