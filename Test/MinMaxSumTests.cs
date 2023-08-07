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
    }
}