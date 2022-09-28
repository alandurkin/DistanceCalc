using System.Drawing;

namespace Services.Calculators;

public interface ICalculator
{
    double GetDistance(PointF a, PointF b);
}
