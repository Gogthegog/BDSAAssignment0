using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IsLeapYear_returns_true_for_divisible_by_four()
        {
            var output = Program.IsLeapYear(2020);

            Assert.True(output);
        }

        [Fact]
        public void IsLeapYear_returns_false_for__not_divisible_by_four()
        {
            var output = Program.IsLeapYear(2021);
            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_returns_false_for_non_quad_centurial_year()
        {
            var output = Program.IsLeapYear(1700);

            Assert.False(output);
        }

        [Fact]
        public void IsLeapYear_returns_true_for_quad_centurial_year()
        {
            var output = Program.IsLeapYear(2000);

            Assert.True(output);
        }

        [Fact]
        public void Main_Accepts_only_integers()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Console.SetIn(new StringReader("ABC"));
            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Enter year: Input has to be an integer equal to or more than 1582.", output);
        }

        [Fact]
        public void IsLeapYear_Accepts_only_years_from_1582()
        {
            Assert.Throws<ArgumentException>(() => Program.IsLeapYear(10));
        }
    }
}
