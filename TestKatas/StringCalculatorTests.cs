using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestKatas
{
    public class StringCalculatorTests
    {
        [Fact]
        public void GivenThatIHaveAString1_WhenConverting_ShouldBeNumber1()
        {
            int Result = new StringCalculator().SumNumbers("1");
            Result.Should().Be(1);            
        }

        [Fact]
        public void GivenThatIHaveAString1Comma2_WhenConverting_ShouldBeSum3()
        {
            int Result = new StringCalculator().SumNumbers("1,2");
            Result.Should().Be(3);
        }

        [Fact]
        public void GivenThatIHaveAStringEmpty_WhenConverting_ShouldBe0()
        {
            int Result = new StringCalculator().SumNumbers("");
            Result.Should().Be(0);
        }

        [Fact]
        public void GivenThatIHaveAString12345_WhenConverting_ShouldBeSum15()
        {
            int Result = new StringCalculator().SumNumbers("1,2,3,4,5");
            Result.Should().Be(15);
        }

        [Fact]
        public void GivenThatIHaveAStringWithNumbersSmallerThanZero_WhenConverting_ThenShowException()
        {
            StringCalculator Calculator = new StringCalculator();

            Calculator.Invoking(CheckNumber => CheckNumber.SumNumbers("1,2,-3,4"))
                .Should().Throw<Exception>().WithMessage("The Number -3 is smaller than Zero. You need fill out a number bigger than zero to continue.");
        }
        [Fact]
        public void GivenThatIHaveAStringWithOneNumberSmallerThanZero_WhenConverting_ThenShowException()
        {
            StringCalculator Calculator = new StringCalculator();

            Calculator.Invoking(CheckNumber => CheckNumber.SumNumbers("-5"))
                .Should().Throw<Exception>().WithMessage("The Number -5 is smaller than Zero. You need fill out a number bigger than zero to continue.");
        }

        [Fact]
        public void GivenThatIHaveAStringWithSpecialDelimitor_WhenConverting_ShouldBeSum()
        {
            int Result = new StringCalculator().SumNumbers("1,2\n3,4,5");
            Result.Should().Be(15);
        }

        [Fact]
        public void GivenThatIHaveAStringWithNumberBiggerThan1000_WhenConverting_ShouldBeReduce1000()
        {
            int Result = new StringCalculator().SumNumbers("1,2,1001,3");
            Result.Should().Be(6);
        }

        [Fact]
        public void GivenThatIHaveAStringWithCustomizedDelimitor_WhenConverting_ShouldBeSum()
        {
            int Result = new StringCalculator().SumNumbers("//;\n1;2;3;4;5");
            Result.Should().Be(15);
        }

        [Fact]
        public void GivenThatIHaveAStringWithSeveralDelimitors_WhenConverting_ShoulBeSum()
        {
            int Result = new StringCalculator().SumNumbers("//;\n1;2;3,4\n5");
            Result.Should().Be(15);
        }

        [Fact]
        public void GivenThatIHaveAStringWithSeveralDelimitorsWithBrackets_WhenConverting_ShouldBeSum()
        {
            int Result = new StringCalculator().SumNumbers("//[|] [_]\n1|2_3|4,5");
            Result.Should().Be(15);
        }
    }
}
