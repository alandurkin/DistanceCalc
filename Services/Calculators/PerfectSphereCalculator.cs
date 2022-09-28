using System.Drawing;

namespace Services.Calculators;
public class PerfectSphereCalculator : ICalculator
{
    const double EARTHS_RADIUS = 6371f;

    public double GetDistance(PointF a, PointF b)
    {
        if (a == b)
        {
            return 0;
        }
        var x = ToRadians(90f - a.X);
        var y = ToRadians(90f - b.X);
        var z = ToRadians(a.Y - b.Y);
        var cosP = Math.Cos(x) * Math.Cos(y) + Math.Sin(x) * Math.Sin(y) * Math.Cos(z);
        return Math.Abs(cosP) * EARTHS_RADIUS;
    }

    private static double ToRadians(double degrees)
    {
        return degrees * (180.0 / Math.PI);
    }
}
