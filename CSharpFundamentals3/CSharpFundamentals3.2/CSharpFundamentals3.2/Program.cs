/* #2

class PrintNumbersInReverseOrder
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers[i] = number;
        }

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");  // Use Console.Write instead of Console.WriteLine
        }
    }
} */

/* #3 
 * 
decimal[] numbers = Console.ReadLine().Split(' ') // Split the input string by spaces
                                   .Select(decimal.Parse) // Convert each part to decimal
                                   .ToArray(); // Convert the result into an array of decimals

foreach (decimal number in numbers)
{
    // Round the decimal number using MidpointRounding.AwayFromZero and output it
    Console.WriteLine(number + " => " + Math.Round(number, MidpointRounding.AwayFromZero));
} */

/* 4

var items = Console.ReadLine().Split(' ').ToArray();

for (int i = 0; i < items.Length / 2; i++)

{

    var oldElement = items[i];

    items[i] = items[items.Length - 1 - i];

    items[items.Length - 1 - i] = oldElement;

}

Console.WriteLine(string.Join(" ", items)); */

/* #8
 
using System;
using System.Linq;
 
class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int finalResult = 0;
        int firstLength = originalArray.Length - 1;
        for (int i = 0; i < firstLength; i++)
        {
            int[] modifiedArray = new int[originalArray.Length - 1];
                for (int j = 0; j < modifiedArray.Length; j++)
                    modifiedArray[j] = originalArray[j] + originalArray[j + 1];
                originalArray = modifiedArray;
            finalResult = modifiedArray[0];
        }
        Console.WriteLine(finalResult);
    }
} */