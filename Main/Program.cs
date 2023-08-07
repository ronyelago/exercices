﻿using Main.Algorithms;

namespace Main;

class Program
{
    public static void Main(string[] args)
    {
        StairCase stairCase = new();

        Console.WriteLine("Type a number for the stair: ");
        var stair = stairCase.GenerateStair(int.Parse(Console.ReadLine()));

        foreach (string degree in stair)
        {
            Console.WriteLine(degree);
        }
    }
}