/* #1

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = -1;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
} */

/* #2

using System;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            numbers[i] += numbers[numbers.Count - 1]; // Adding the last element of the list to the current element
            numbers.RemoveAt(numbers.Count - 1); //  Removing the last element from the list after it has been added to the current element
        }
        Console.WriteLine(string.Join(" ", numbers)); // Outputting the final list as a string of space-separated values
    }
} */

/* #3

using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> mergedList = new List<int>();

        int longest = Math.Max(firstList.Count, secondList.Count);

        for (int i = 0; i < longest; i++) // length of longer list
        {
            if (firstList.Count > i) // Check if the first list has an element at the current index.
            {
                mergedList.Add(firstList[i]);
            }
            if (secondList.Count > i)
            {
                mergedList.Add(secondList[i]);
            }
        }
        Console.WriteLine(string.Join(" ", mergedList));
    }
} */

/* #4

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<string> products = new List<string>();

        for (int i = 0;  i < n; i++)
        {
            string currentProduct = Console.ReadLine();
            products.Add(currentProduct);
        }

        products.Sort();

        for(int i = 0;i < products.Count;i++) { Console.WriteLine($"{i+1}.{products[i]}"); }
    }
}*/

/* #5

using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        numbers.RemoveAll(n => n < 0); // Remove all numbers from the 'numbers' list that are less than 0.
        numbers.Reverse();
        if (numbers.Count == 0) { Console.WriteLine("empty"); }
        else { Console.WriteLine(string.Join(" ", numbers)); }
    }
} */

/* #6
 * 
 using System;

class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (true) // infinite loop
        {
            string line = Console.ReadLine();

            if (line == "end") { break; }

            string[] tokens = line.Split(); // Split the command into parts (tokens), the first token is the command type

            switch (tokens[0])
            {
                case "Add":
                    int numberToAdd = int.Parse(tokens[1]);
                    numbers.Add(numberToAdd); break;
                case "Remove":
                    int numberToRemove = int.Parse(tokens[1]);
                    numbers.Remove(numberToRemove); break;
                case "RemoveAt":
                    int indexToRemove = int.Parse(tokens[1]);
                    numbers.RemoveAt(indexToRemove); break;
                case "Insert":
                    int numberToInsert = int.Parse(tokens[1]);
                    int indexToInsert = int.Parse(tokens[2]);
                    numbers.Insert(indexToInsert, numberToInsert); break;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
} */

/* #7

using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()                      
                .Select(int.Parse)           
                .ToList();                    

            // Create a copy of the numbers list to track changes and compare later.
            List<int> saveNumbers = new List<int>();

            // Copy all elements from 'numbers' into 'saveNumbers' list to track original state.
            for (int i = 0; i < numbers.Count; i++)
            {
                saveNumbers.Add(numbers[i]);
            }

            string command = Console.ReadLine();

            // Continue processing commands as long as they are not "end".
            while (command != "end")
            {
                // Split the command into parts (operation and parameters).
                List<string> listOperations = command.Split().ToList();

                string operation = listOperations[0];
                int number = 0;
                int index = 0;
                int numberTask = 0;
                string condition = string.Empty;

                // Parse parameters from the command based on the number of tokens in the input.
                if (listOperations.Count == 2)
                {
                    number = int.Parse(listOperations[1]);    // Only one parameter (number).
                    numberTask = number;                       // Set numberTask as the parsed number.
                }
                else if (listOperations.Count == 3)
                {
                    index = int.Parse(listOperations[2]);      // Parse the index.
                    number = int.Parse(listOperations[2]);     // The number can be same as index (a special case).
                    condition = listOperations[1];             // The condition ("<", ">", etc.).
                }

                // Special case for the "Insert" operation, the number is extracted separately.
                if (operation == "Insert")
                {
                    numberTask = int.Parse(listOperations[1]);  // The number to insert.
                }

                switch (operation)
                {
                    case "Contains":
                        CheckIfNumberIsIn(numbers, command, number);
                        break;
                    case "PrintEven":
                        PrintEvenNumbers(numbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbers(numbers);
                        break;
                    case "GetSum":
                        PrintSumOfNumbers(numbers);
                        break;
                    case "Filter":
                        PrintFilterNumbers(numbers, condition, number);
                        break;
                }
             
                CommandsFromThePreviousTask(numbers, operation, numberTask, index);
                
                command = Console.ReadLine();
            }

            // Check if the current numbers list differs from the original 'saveNumbers' list.
            bool notEqual = false;

            for (int i = 0; i < Math.Max(numbers.Count, saveNumbers.Count); i++)
            {
                
                if (numbers.Count > saveNumbers.Count || saveNumbers.Count > numbers.Count)
                {
                    notEqual = true;
                    break;
                }

                
                if (numbers[i] != saveNumbers[i])
                {
                    notEqual = true;
                    break;
                }
            }

            
            if (notEqual)
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }

        
        static void CheckIfNumberIsIn(List<int> numbers, string command, int number)
        {
            if (numbers.Contains(number))  
            {
                Console.WriteLine("Yes");  
            }
            else
            {
                Console.WriteLine("No such number");  
            }
        }

       
        static void PrintEvenNumbers(List<int> numbers)
        {
            List<int> returnEvenNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)  
                {
                    returnEvenNumbers.Add(numbers[i]);  
                }
            }

            Console.WriteLine(String.Join(" ", returnEvenNumbers)); 
        }

        
        static void PrintOddNumbers(List<int> numbers)
        {
            List<int> returnOddNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)  
                {
                    returnOddNumbers.Add(numbers[i]);  
                }
            }

            Console.WriteLine(String.Join(" ", returnOddNumbers));  
        }

        static void PrintSumOfNumbers(List<int> numbers)
        {
            long sumNumbers = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sumNumbers += numbers[i];  // Sum all numbers in the list.
            }

            Console.WriteLine(sumNumbers);  // Print the sum.
        }

        
        static void PrintFilterNumbers(List<int> numbers, string condition, int number)
        {
            List<int> filteredNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (condition == "<" && numbers[i] < number)  
                {
                    filteredNumbers.Add(numbers[i]);
                }
                else if (condition == ">" && numbers[i] > number)  
                {
                    filteredNumbers.Add(numbers[i]);
                }
                else if (condition == ">=" && numbers[i] >= number)  
                {
                    filteredNumbers.Add(numbers[i]);
                }
                else if (condition == "<=" && numbers[i] <= number)  
                {
                    filteredNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(String.Join(" ", filteredNumbers));  
        }

        
        static List<int> CommandsFromThePreviousTask(List<int> numbers, string operation, int number, int index)
        {
            switch (operation)
            {
                case "Add":
                    numbers.Add(number);  
                    break;
                case "Remove":
                    numbers.Remove(number); 
                    break;
                case "RemoveAt":
                    numbers.RemoveAt(number);  
                    break;
                case "Insert":
                    numbers.Insert(index, number);  
                    break;
            }

            return numbers;  
        }
    }
} */