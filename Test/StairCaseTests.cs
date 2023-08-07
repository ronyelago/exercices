using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Main.Algorithms;
using Xunit;

namespace RankTests;

public class StairCaseTests
{
    [Fact]
    public void GenerateStair_Should_Print_Correct_Stairs()
    {
        // Arrange
        int n = 5;
        List<string> expectedStairs = new List<string>
        {
            "    #",
            "   ##",
            "  ###",
            " ####",
            "#####"
        };
        
        StairCase stairCase = new StairCase();
        
        // Act
        var generatedStair = stairCase.GenerateStair(n);
        
        // Assert
        Assert.Equal(expectedStairs, generatedStair);
    }

    [Fact]
    public void GenerateStair_PassZero_Should_NotPrintStair()
    {
        int n = 0;
        StairCase stairCase = new();

        var noStair = stairCase.GenerateStair(n);

        Assert.False(noStair.Any());
    }
}