// Created by: Venika Sem
// Created on: Mar 2022
//
// This program does calculations

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a square
        float sideValue;

        Console.WriteLine("This program finds the area of a square.");
        Console.WriteLine("");
        Console.WriteLine("Enter the side value (cm) : ");
        sideValue = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("The area of the square is " + ((sideValue * sideValue).ToString("0.00") + " " + "cm²."));

        Console.WriteLine("\nDone.");
    }
}