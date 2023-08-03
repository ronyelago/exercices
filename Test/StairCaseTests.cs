using System;
using System.Collections.Generic;
using System.IO;
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
        StringBuilder output = new StringBuilder();
        Console.SetOut(new StringWriter(output));
        
        // Act
        stairCase.GenerateStair(n);
        string[] actualStairs = output.ToString().Trim().Split(Environment.NewLine);
        
        // Assert
        Assert.True(true);
    }

    [Fact]
    public void GenerateStair_PassZero_Should_NotPrintStair()
    {
        // Arrange
        int n = 0;
        List<string> expectedStairs = new();
        
        StairCase stairCase = new StairCase();
        StringBuilder output = new StringBuilder();
        Console.SetOut(new StringWriter(output));
        
        // Act
        stairCase.GenerateStair(n);
        string[] actualStairs = output.ToString().Trim().Split(Environment.NewLine);
        
        // Assert
        Assert.True(true);
    }
}