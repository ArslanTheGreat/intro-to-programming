

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }


    [Theory]
    [InlineData("2", 2)]
    public void CanAddAnInteger(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    // I want to add 2 numbers
    // - `Add("1,2") => 3`
    [Theory]
    [InlineData("1,2", 3)]
    public void CanAddTwoIntegers(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }
    
    // Add more then 2 numbers
    [Theory]
    [InlineData("1,2,3", 6)]
    public void CanAddMultipleIntegers(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    // Handle new lines between numbers (instead of commas)
    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    public void CanHandleNewLinesBetweenNumbers(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }
}
