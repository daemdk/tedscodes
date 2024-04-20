public class DeepPerson : ICloneable
{
    public string? Name { get; set; }
    public Address Address { get; set; } = new();
    public object Clone()
    {
        var serialized = System.Text.Json.JsonSerializer.Serialize(this);
        return System.Text.Json.JsonSerializer.Deserialize<DeepPerson>(serialized)!;
    }
}