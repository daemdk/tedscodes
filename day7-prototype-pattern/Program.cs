// Day 7 - Prototype Pattern
//
// Prototype Pattern
// The Prototype pattern is a generative design pattern used to create new objects by cloning existing objects when creating the object is expensive or complex. In C#, you can implement this pattern through the ICloneable interface.
//
// Shallow Copy
// Shallow Copy is one of the ways to copy an object in C#. It copies the object's fields to a new object, but if the field is a reference type, it does not copy the referenced object itself, but only the reference. That is, the original object and the cloned object share data of the same reference type. This is because for value type fields, the copy is done bit by bit, but for reference type fields, only the address of the object is copied.

// Deep Copy
// Implementing deep copy in the prototype pattern is important when the object contains fields of reference types. A deep copy not only clones all fields of an object, but also recursively clones the objects pointed to by reference type fields. This ensures that there are no shared references between the original and cloned objects, so modifications to one object do not affect the other.

Console.WriteLine("Hello, Day7!");

//**************************
// Shallow Copy
//**************************
Console.WriteLine();
Console.WriteLine("Shallow Copy");

ShallowPerson shallowOriginal = new ShallowPerson();
shallowOriginal.Name = "Name";
shallowOriginal.Address.StreetName = "Street 1";

ShallowPerson shallowClone = (ShallowPerson)shallowOriginal.Clone();
Console.WriteLine("==> Before Changed. Original: {0}, Clone: {1}", shallowOriginal.Address.StreetName, shallowClone.Address.StreetName);
shallowClone.Address.StreetName = "Street 2";
Console.WriteLine("==> After Changed.  Original: {0}, Clone: {1}", shallowOriginal.Address.StreetName, shallowClone.Address.StreetName);

//**************************
// Deop Copy
//**************************
Console.WriteLine();
Console.WriteLine("Deop Copy");

DeepPerson deepOriginal = new DeepPerson();
deepOriginal.Name = "Name";
deepOriginal.Address.StreetName = "Street 1";

DeepPerson deepClone = (DeepPerson)deepOriginal.Clone();
Console.WriteLine("==> Before Changed. Original: {0}, Clone: {1}", deepOriginal.Address.StreetName, deepClone.Address.StreetName);
deepClone.Address.StreetName = "Street 2";
Console.WriteLine("==> After Changed.  Original: {0}, Clone: {1}", deepOriginal.Address.StreetName, deepClone.Address.StreetName);

