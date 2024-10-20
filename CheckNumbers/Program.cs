using System;
using System.Collections.Generic;
using System.Linq;

public static class NumberExtensions
{
    // Extension method to filter numbers based on a Func delegate
    public static List<int> FilterNumbers(this List<int> numbers, Func<int, bool> filter)
    {
        return numbers.Where(filter).ToList();
    }
}

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Use extension method to get even numbers
        List<int> evenNumbers = numbers.FilterNumbers(IsEven);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        // Use extension method to get odd numbers
        List<int> oddNumbers = numbers.FilterNumbers(IsOdd);
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));
    }

    // Method to check if a number is even
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Method to check if a number is odd
    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }
}
