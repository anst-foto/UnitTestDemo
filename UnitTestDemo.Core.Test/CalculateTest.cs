namespace UnitTestDemo.Core.Test;

public class CalculateTest
{
    const double x = 1;
    const double y = 2;
    const double y0 = 0;
    
    const double expectedAdd = 3;
    const double expectedSub = -1;
    const double expectedMul = 2;
    const double expectedDiv = 0.5;
    
    [Fact]
    public void Add_Test()
    {
        var actual = Calculate.Add(x, y);
        Assert.Equal(expectedAdd, actual);
    }
    
    [Fact]
    public void Sub_Test()
    {
        var actual = Calculate.Sub(x, y);
        Assert.Equal(expectedSub, actual);
    }
    
    [Fact]
    public void Mul_Test()
    {
        var actual = Calculate.Mul(x, y);
        Assert.Equal(expectedMul, actual);
    }
    
    [Fact]
    public void Div_PositiveTest()
    {
        var actual = Calculate.Div(x, y);
        Assert.Equal(expectedDiv, actual);
    }

    [Fact]
    public void Div_ZeroTest()
    {
        Assert.Throws<DivideByZeroException>(() => Calculate.Div(x, y0));
    }
}