using CalculateArea;
using CalculateArea.Figures;
using CalculateArea.Interfaces;

var area1 = Area.Get(5);
var area2 = Area.Get(5, 3, 4);

Console.WriteLine(area1);
Console.WriteLine(area2);
Console.WriteLine(new Triangle(5, 4, 3).IsRightTriangle);
