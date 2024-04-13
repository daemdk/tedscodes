
Console.WriteLine("Hello, Day2");

// Create product list
List<Product> products = new()
{
    new Product { Name = "Laptop", Price = 1200 },
    new Product { Name = "Smartphone", Price = 800 },
    new Product { Name = "Tablet", Price = 600 },
    new Product { Name = "Monitor", Price = 300 },
    new Product { Name = "Keyboard", Price = 50 },
    new Product { Name = "Mouse", Price = 25 },
    new Product { Name = "Smartwatch", Price = 250 },
    new Product { Name = "Headphones", Price = 150 },
    new Product { Name = "Speaker", Price = 100 },
    new Product { Name = "Camera", Price = 500 }
};

// Create LinqExample instance
LinqExample example = new();

// Call the DisplayProducts method to display products over 500
example.DisplayProducts(products, 500);
