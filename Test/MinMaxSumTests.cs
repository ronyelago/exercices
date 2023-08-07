using System;
using System.Collections.Generic;
using Main.Algorithms;
using Xunit;
using Serilog;
using Microsoft.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Test
{
    public class MinMaxSumTests
    {
        private readonly ILogger logger;
        private MinMaxSum minMaxSum;

        public MinMaxSumTests()
        {   
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var loggerFactory = new Serilog.Extensions.Logging.SerilogLoggerFactory();
            logger = loggerFactory.CreateLogger<MinMaxSumTests>();

            minMaxSum = new();
        }

        [Fact]
        public void MaxSum_Returns_Zero_For_Empty_List()
        {
            // Arrange
            List<int> numbers = new();

            // Act
            int result = minMaxSum.MaxSum(numbers);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxSum_Returns_Correct_Maximum_Sum_With_Positive_Numbers()
        {
            // Arrange
            List<int> numbers = new() { 5, 9, 3, 2, 8 };

            // Act
            int result = minMaxSum.MaxSum(numbers);

            // Assert
            Assert.Equal(25, result);
        }

        [Fact]
        public void MaxSum_Returns_Correct_Maximum_Sum_With_Negative_Numbers()
        {
            // Arrange
            List<int> numbers = new List<int> { -5, -9, -3, -2, -8 };

            logger.LogInformation("Sorted list:");
            numbers.Sort();
            numbers.ForEach(n => logger.LogInformation(n.ToString()));

            // Act
            int result = minMaxSum.MaxSum(numbers);

            // Assert
            Assert.Equal(-25, result);
        }

        [Fact]
        public void MaxSum_Returns_Correct_Maximum_Sum_With_Mixed_Numbers()
        {
            // Arrange
            List<int> numbers = new List<int> { -5, 4, -3, 7, -8, 2, 6 };

            // Act
            int result = minMaxSum.MaxSum(numbers);

            // Assert
            Assert.Equal(17, result); // The maximum sum is achieved by adding the three largest numbers: 7 + 6 + 4 = 17
        }
    }
}