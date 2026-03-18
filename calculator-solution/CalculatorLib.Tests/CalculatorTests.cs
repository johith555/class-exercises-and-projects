using System;
using Xunit;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            Assert.Equal(15, _calculator.Add(10, 5));
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            Assert.Equal(5, _calculator.Subtract(10, 5));
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            Assert.Equal(50, _calculator.Multiply(10, 5));
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            Assert.Equal(2, _calculator.Divide(10, 5));
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Fact]
        public void Add_WithZero_ShouldReturnSameNumber()
        {
            Assert.Equal(10, _calculator.Add(10, 0));
        }
    }
}