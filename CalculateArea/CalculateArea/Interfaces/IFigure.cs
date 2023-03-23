namespace CalculateArea.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFigure
    {
        public string Name { get; }

        public double GetArea();
    }
}
