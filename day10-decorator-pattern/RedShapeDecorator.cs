// ConcreteDecorator class
public class RedShapeDecorator : ShapeDecorator
{
    public RedShapeDecorator(IShape shape) : base(shape)
    {
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Adding red color");
    }
}