
// 'Adapter' class implements the 'ITarget' interface and wraps an 'Adaptee' object.
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"This is the adapted '{_adaptee.GetSpecificRequest()}'";
    }
}
