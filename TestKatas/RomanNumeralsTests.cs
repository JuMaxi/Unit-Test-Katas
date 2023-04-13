using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestKatas
{
    public class RomanNumeralsTests
    {
        [Fact]
        public void GivenRomanNumeralI_WhenConverting_ShouldBe1()
        {
            int result = new RomanNumerals().ConvertToNumber("I");
            result.Should().Be(1);
        }

        [Fact]
        public void GivenRomanNumeralV_WhenConverting_ShouldBe5()
        {
            int result = new RomanNumerals().ConvertToNumber("V");
            result.Should().Be(5);
        }

        [Fact]
        public void GivenRomanNumeralX_WhenConverting_ShouldBe10()
        {
            int result = new RomanNumerals().ConvertToNumber("X");
            result.Should().Be(10);
        }

        [Fact]
        public void GivenRomanNumeralL_WhenConverting_ShouldBe50()
        {
            int result = new RomanNumerals().ConvertToNumber("L");
            result.Should().Be(50);
        }

        [Fact]
        public void GivenRomanNumeralC_WhenConverting_ShouldBe100()
        {
            int result = new RomanNumerals().ConvertToNumber("C");
            result.Should().Be(100);
        }

        [Fact]
        public void GivenRomanNumeralD_WhenConverting_ShouldBe500()
        {
            int result = new RomanNumerals().ConvertToNumber("D");
            result.Should().Be(500);
        }

        [Fact]
        public void GivenRomanNumeralM_WhenConverting_ShouldBe1000()
        {
            int result = new RomanNumerals().ConvertToNumber("M");
            result.Should().Be(1000);
        }

        [Fact]
        public void GivenRomanNumeralII_WhenConverting_ShouldBe2()
        {
            int result = new RomanNumerals().ConvertToNumber("II");
            result.Should().Be(2);
        }

        [Fact]
        public void GivenRomanNumeralVI_WhenConverting_ShouldBe6()
        {
            int result = new RomanNumerals().ConvertToNumber("VI");
            result.Should().Be(6);
        }

        [Fact]
        public void GivenRomanNumeralIV_WhenConverting_ShouldBe4()
        {
            int result = new RomanNumerals().ConvertToNumber("IV");
            result.Should().Be(4);
        }

        [Fact]
        public void GivenRomanNumeralCurrentYear_WhenConverting_ShouldBeCurrentYear()
        {
            int result = new RomanNumerals().ConvertToNumber("MMXXIII");
            result.Should().Be(2023);

        }
    }
}
