/// <summary>
/// ComputerBuilder
/// </summary>
public class ComputerBuilder
{
    public string? CPU { get; private set; }
    public string? RAM { get; private set; }
    public string? Storage { get; private set; }
    public string? GraphicsCard { get; private set; }

    public ComputerBuilder SetCPU(string cpu)
    {
        CPU = cpu;
        return this;
    }

    public ComputerBuilder SetRAM(string ram)
    {
        RAM = ram;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        Storage = storage;
        return this;
    }

    public ComputerBuilder SetGraphicsCard(string graphicsCard)
    {
        GraphicsCard = graphicsCard;
        return this;
    }

    public Computer Build()
    {
        return new Computer(this);
    }
}