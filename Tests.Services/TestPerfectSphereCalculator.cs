using System.Drawing;
using Services.Calculators;

namespace Tests.Services;



[TestClass]
public class TestPerfectSphereCalculator
{
    [TestMethod]
    [DataRow(153.297975f, -6.372663f, 41.385101f, -81.440440f, 5365)]
    [DataRow(53.2755f, -7.4934f, 8.9806f, 38.7578f, 3851)]
    public void TestGetDistance(float latA, float lonA, float latB, float lonB, double expected)
    {
        var a = new PointF(latA, lonA);
        var b = new PointF(latA, lonB);
        var calc = new PerfectSphereCalculator();
        Assert.AreEqual(expected, Math.Round(calc.GetDistance(a, b)));
    }
}