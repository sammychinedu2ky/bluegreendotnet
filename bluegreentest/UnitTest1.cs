
namespace bluegreentest;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)] // First execution
    [InlineData(5,4,9)] // Second execution
    public void Calc_Can_Add_Two_Integers(int a, int b, int expected)
    {
        var result = Calc.Add(a, b);
        Assert.Equal(expected, result);
    }
}
