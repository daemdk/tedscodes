public abstract class HouseTemplate
{
    // Template method (defines the overall algorithm)
    public void BuildHouse()
    {
        BuildFoundation();
        BuildPillars();
        BuildWalls();
        BuildWindows();
    }

    // Abstract methods (to be implemented by subclasses)
    protected abstract void BuildFoundation();
    protected abstract void BuildPillars();
    protected abstract void BuildWalls();
    protected abstract void BuildWindows();
}