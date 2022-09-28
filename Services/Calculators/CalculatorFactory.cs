namespace Services.Calculators;

static class CalculatorFactory
{
    public static ICalculator GetCalculator(CalculatorTypes calculatorType)
    {
        if (calculatorType == CalculatorTypes.PerfectSphere)
        {
            return new PerfectSphereCalculator();
        }

        throw new Exception("Unsupported Calculator Type!"); // TODO: Make a custom exception.
    }
}