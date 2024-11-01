public static class ConversorTemperatura
{
    public static double CelsiusParaFahreheit(double celsius)
    {
        return (celsius*9/5)+32;
    }
    public static double farenheitParaCelsius(double Fahrenheit)
    {
        return (Fahrenheit - 32) * 5/9;
    }
}