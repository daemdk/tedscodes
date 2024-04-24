// Decorator class
public abstract class ShapeDecorator : IShape
{
    protected IShape decoratedShape;

    public ShapeDecorator(IShape shape)
    {
        this.decoratedShape = shape;
    }

    public virtual void Draw()
    {
        decoratedShape.Draw();
    }
}