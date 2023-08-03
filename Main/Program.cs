﻿using Main.Algorithms;

namespace Main;

class Program
{
    public static void Main(string[] args)
    {
        StairCase stairCase = new();

        Console.WriteLine("Digite um numero entre 1 e 100: ");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        stairCase.GenerateStair(n);
    }
}