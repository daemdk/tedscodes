/// <summary>
/// ComputerBuilder
/// </summary>
public class Computer
{
    public string? CPU { get; set; }
    public string? RAM { get; set; }
    public string? Storage { get; set; }
    public string? GraphicsCard { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GraphicsCard: {GraphicsCard}";
    }
}
