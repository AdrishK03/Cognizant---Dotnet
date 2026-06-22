namespace Exercise7_FinancialForecasting
{
    internal class Program
    {
        static double Forecast(double currentValue,
                               double growthRate,
                               int years)
        {
            if (years == 0)
                return currentValue;

            return Forecast(
                currentValue * (1 + growthRate),
                growthRate,
                years - 1);
        }

        static void Main(string[] args)
        {
            double currentValue = 10000;
            double growthRate = 0.10;
            int years = 5;

            double futureValue =
                Forecast(currentValue, growthRate, years);

            Console.WriteLine(
                $"Future Value after {years} years = {futureValue:F2}");
        }
    }
}