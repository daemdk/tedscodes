
public class ConcreteHouse : HouseTemplate
{
    protected override void BuildFoundation()
    {
        Console.WriteLine("Building concrete foundation");
    }

    protected override void BuildPillars()
    {
        Console.WriteLine("Building concrete pillars");
    }

    protected override void BuildWalls()
    {
        Console.WriteLine("Building concrete walls");
    }

    protected override void BuildWindows()
    {
        Console.WriteLine("Building concrete windows");
    }
}