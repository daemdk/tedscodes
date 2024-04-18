/// <summary>
/// ComputerBuilder
/// </summary>
public class ComputerBuilder
{
    private Computer _computer = new Computer();

    public ComputerBuilder WithCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder WithRAM(string ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder WithStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }

    public ComputerBuilder WithGraphicsCard(string graphicsCard)
    {
        _computer.GraphicsCard = graphicsCard;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}
