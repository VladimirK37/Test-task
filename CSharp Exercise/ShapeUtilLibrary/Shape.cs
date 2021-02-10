namespace ShapeUtilLibrary
{
    /// <summary>
    ///  Base class for working with shapes. 
    /// </summary>
    public abstract class Shape : IValidatable
    {
        /// <summary>
        /// Calculates and returns area of the shape. 
        /// </summary>
        public abstract double GetArea();

        /// <summary>
        /// Performs validation check.
        /// </summary>
        public abstract bool IsValid();
    }
}
