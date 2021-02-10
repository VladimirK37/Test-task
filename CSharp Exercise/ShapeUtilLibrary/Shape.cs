namespace ShapeUtilLibrary
{
    public abstract class Shape : IValidatable
    {
        public abstract double GetArea();

        public abstract bool IsValid();
    }
}
