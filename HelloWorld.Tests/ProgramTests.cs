using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        // int[] testYears = new int[] {8, 15, 20, 1200, 1500, 1600, 2020, 2021}
        // Check if a year is exactly divisible by 4
        // If a year is also exactly divisible by 100, then they should be checked if they are divisible by 400
        [Fact]
        public void check_if_8_is_leap_year()
        {
            // Arrange
            int testYear = 8;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.True (output);
        }

        [Fact]
        public void check_if_15_is_leap_year()
        {
            // Arrange
            int testYear = 15;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.False (output);
        }

        [Fact]
        public void check_if_20_is_leap_year()
        {
            // Arrange
            int testYear = 20;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.True (output);
        }

        [Fact]
        public void check_if_1200_is_leap_year()
        {
            // Arrange
            int testYear = 1200;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.True (output);
        }

        [Fact]
        public void check_if_1500_is_leap_year()
        {
            // Arrange
            int testYear = 1500;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.False (output);
        }

        [Fact]
        public void check_if_1600_is_leap_year()
        {
            // Arrange
            int testYear = 1600;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.True (output);
        }

        [Fact]
        public void check_if_2020_is_leap_year()
        {
            // Arrange
            int testYear = 2020;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.True (output);
        }

        [Fact]
        public void check_if_2021_is_leap_year()
        {
            // Arrange
            int testYear = 2021;

            // Act
            // Insert a series of years into the function
            var output = Program.isLeapYear(testYear);

            // Assert
            Assert.False (output);
        }
    }
}
