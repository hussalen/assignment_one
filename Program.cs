﻿namespace assignment_one;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, World!");
    }

    static int CalculateLolAverage(int[] ints)
    {
        int sum = 0;
        foreach (int i in ints)
        {
            Console.WriteLine("Testing conflict");
            sum += i;
        }
        return sum / ints.Length;
    }

    static int GetMaxFromArray(int[] ints)
    {
        return ints.Max();
    }
}
