﻿using Main.Algorithms;

namespace Main;

class Program
{
    public static void Main(string[] args)
    {
        Candles candles = new();

        Console.WriteLine("Digite a altura das velas:");
        var candleList = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(c => int.Parse(c)).ToList();

        Console.WriteLine($"Number of tallest: {candles.BirthdayCakeCandles(candleList)}");
    }
}