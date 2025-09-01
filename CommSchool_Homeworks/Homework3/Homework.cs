using System;

namespace CommSchool_Homeworks.Homework3;

public class Homework
{
    static void Main(string[] args)
    {
        // Task 1
        Console.Write("Enter a number: ");
        var inputNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(inputNumber % 5 == 0 ? "YES" : "NO");
        Console.WriteLine();
        
        // Task 2
        Console.WriteLine("Enter X and Y numbers:");
        Console.Write("X = ");
        var x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y = ");
        var y = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"X + Y = {x + y}" );
        Console.WriteLine(x < y ? $"Y - X = {y - x}" : $"X - Y  = {x - y}");
        Console.WriteLine($"X * Y = {x * y}");
        if (x != 0 && y != 0) Console.WriteLine(x < y ? $"Y / X = {y / x}, with remainder: {y % x}" : $"X / Y  = {x / y}, with remainder: {x % y}");
        else Console.WriteLine("Division by zero not allowed");
        
        Console.WriteLine();
        
        // Task 3
        Console.WriteLine("Enter numbers to swap:");
        Console.Write("X = ");
        var x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y = ");
        var y2 = Convert.ToInt32(Console.ReadLine());
        
        x1 += y2;
        y2 = x1 - y2;
        x1 -= y2;
        
        Console.WriteLine($"X = {x1}, Y = {y2}");
        Console.WriteLine();
        
        // Task 4
        Console.Write("Enter a number: ");
        var inputNumber2 = Convert.ToInt32(Console.ReadLine());

        for (var i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{inputNumber2} x {i} = {inputNumber2 * i}");
        }
        
        Console.WriteLine();
        
        
        // Task 5
        Console.Write("Enter a number: ");
        var inputNumber3 = Convert.ToInt32(Console.ReadLine());
        
        for (var i = 1; i < inputNumber3; i++)
        {
            Console.WriteLine(i % 2 == 0 ? $"{i}^2 = {i * i}" : "");
        }
    }
}