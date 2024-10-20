using System;
using System.Collections.Generic;
using System.Linq;



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
   
    }
}
