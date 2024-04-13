public class LinqExample
{
    public void DisplayProducts(List<Product> products, decimal price)
    {
        var expensiveProducts = products.Where(p => p.Price >= price)
                                        .OrderBy(p => p.Name);

        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
        }
    }
}
