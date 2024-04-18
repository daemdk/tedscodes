/// <summary>
/// ComputerBuilder
/// </summary>
public class Computer
{
    public string? CPU { get; private set; }
    public string? RAM { get; private set; }
    public string? Storage { get; private set; }
    public string? GraphicsCard { get; private set; }

    public Computer(ComputerBuilder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
        GraphicsCard = builder.GraphicsCard;
    }

    public override string ToString()
    {
        return $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GraphicsCard: {GraphicsCard}";
    }
}