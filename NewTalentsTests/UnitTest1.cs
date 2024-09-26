using System;
using NewTalents;

namespace NewTalentsTests;

public class UnitTest1
{
    public Calculator initializeCalculator()
    {
        Calculator calculator = new("09/25/2024");
        return calculator;
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 5, 8)]
    public void Sum_Sum2IntValues_ReturnsIntValueOfTheSum(int n1, int n2, int result)
    {
        Calculator calculator = initializeCalculator();

        int resultCalc = calculator.sum(n1, n2);

        Assert.Equal(result, resultCalc);
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 5, 15)]
    public void Multiply_Multiply2IntValues_ReturnsIntValueOfTheMultiply(int n1, int n2, int result)
    {
        Calculator calculator = initializeCalculator();

        int resultCalc = calculator.multiply(n1, n2);

        Assert.Equal(result, resultCalc);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(3, 5, -2)]
    public void Subtract_Subtract2IntValues_ReturnsIntValueOfTheSubtract(int n1, int n2, int result)
    {
        Calculator calculator = initializeCalculator();

        int resultCalc = calculator.subtract(n1, n2);

        Assert.Equal(result, resultCalc);
    }

    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(10, 2, 5)]
    public void Divide_Divide2IntValues_ReturnsIntValueOfTheDivide(int n1, int n2, int result)
    {
        Calculator calculator = initializeCalculator();

        int resultCalc = calculator.divide(n1, n2);

        Assert.Equal(result, resultCalc);
    }

    [Fact]
    public void TestDivisionByZero_DivisionByZero_ReturnException()
    {
        Calculator calculator = initializeCalculator();

        Assert.Throws<DivideByZeroException>(() => calculator.divide(1, 0));
    }

    [Fact]
    public void History_TestHistory_ReturnHistoryWithValues()
    {
        Calculator calculator = initializeCalculator();

        calculator.sum(1, 1);
        calculator.sum(1, 2);
        calculator.sum(1, 3);
        calculator.sum(1, 4);

        var history = calculator.GetHistory();
        foreach (var value in history)
        {
            Console.WriteLine(value);
        }

        Assert.NotEmpty(history);
        Assert.Equal(3, history.Count);
    }
}