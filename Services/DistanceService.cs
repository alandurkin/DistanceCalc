using System.Drawing;
using Services.Calculators;

public class DistanceService
{
    private readonly ICalculator _calculator;

    // This might be better as a parameter but I'm just showing the use of Env vars in containers.
    private readonly bool useKm = Environment.GetEnvironmentVariable("USE_KM") == "true";
    public DistanceService(ICalculator calculator)
    {
        _calculator = calculator;
    }

    public int GetDistance(PointF start, PointF end)
    {
        var kms = _calculator.GetDistance(start, end);

        return Convert.ToInt32(Math.Round(useKm ? kms : InMiles(kms)));
    }

    public double InMiles(double kms)
    {
        return kms * 0.621371;
    }
}