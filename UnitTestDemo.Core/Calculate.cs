namespace UnitTestDemo.Core;

public static class Calculate
{
    public static double Add(double x, double y) => x + y;
    public static double Sub(double x, double y) => x - y;
    public static double Mul(double x, double y) => x * y;

    public static double Div(double x, double y)
    {
        if (y == 0)
        {
            throw new DivideByZeroException();
        }
        return x / y;
    }
}