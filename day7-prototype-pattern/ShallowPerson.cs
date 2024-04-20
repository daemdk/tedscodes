public class ShallowPerson : ICloneable
{
    public string? Name { get; set; }
    public Address Address { get; set; } = new();
    public object Clone()
    {
        return this.MemberwiseClone();
    }
}
