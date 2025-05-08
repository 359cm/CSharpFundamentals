/* 2 
 using System;  

class Program
{
    static void Main()

    {
        PrintInWords(double.Parse(Console.ReadLine()));
    }

    private static void PrintInWords(double grade)

    {
        string gradeInWords = string.Empty;

        if (grade >= 2 && grade <= 2.99) gradeInWords = "Fail";
        if (grade >= 3 && grade <= 3.49) gradeInWords = "Poor";
        if (grade >= 3.5 && grade <= 4.49) gradeInWords = "Good";
        if (grade >= 4.5 && grade <= 5.49) gradeInWords = "Very good";
        if (grade >= 5.5 && grade <= 6.00) gradeInWords = "Excellent";

        Console.WriteLine(gradeInWords);
    }
} */

/* #3
 
using System;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        switch(command)
        {
            case "add":
                Add(a, b);
                break;
            case "subtract":
                Subtract(a, b);
                break;
            case "multiply":
                Multiply(a, b);
                break;
            case "divide":
                Divide(a, b);
                break;
        }
    }

    private static void Add(int a, int b)
    { Console.WriteLine(a + b); }

    private static void Subtract(int a, int b)
    { Console.WriteLine(a - b); }
    private static void Multiply(int a, int b)
    { Console.WriteLine(a * b); }

    private static void Divide (int a, int b)
    { Console.WriteLine(a / b); }
} */

/* #4

using System;
class Program
{
    static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void PrintTri(int n)
    {
        for (int i = 1; i <= n; i++) { PrintLine(1, i); }
        for (int i = n - 1; i >= 1; i--)
        {
            PrintLine(1, i);
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintTri(n);
    }
} */

/* #5

using System;
class Program
{
    static void Orders()
    {
        string prod = Console.ReadLine();
        int quan = int.Parse(Console.ReadLine());
        double price = 0;

        switch (prod)
        {
            case "coffee": price = 1.5; break;
            case "water": price = 1; break;
            case "coke": price = 1.4; break;
            case "snacks": price = 2; break;
        }

        int totalPrice = price * quan;
        Console.WriteLine(totalPrice:F2); 
    }

    static void Main()
    {
        Orders();
    }
} */

/* #6

using System;
class Program
{
    static double GetRectangleArea(double width, double height) { return width * height; }
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = GetRectangleArea(width, height);
        Console.WriteLine(area);
    }
} */

/*#7

using System;
class Program
{
    private static string RepeatString(string str, int count)
    {
        string result = "";
        for (int i= 0; i < count; i++) { result += str; }
        return result;
    }

    static void Main ()
    {
        string a = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string output = RepeatString(a, n);
        Console.WriteLine(output);
    }
} */

/* #9 

using System;

class Program
{
    static int GreaterInt()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        return a > b ? a : b;
    }

    static char GreaterChar()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        return a > b ? a : b;
    }

    static string GreaterString()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        return string.Compare(a, b) > 0 ? a : b; // Compare strings lexicographically (dictionary order)
    }

    static void Main()
    {
        string type = Console.ReadLine();
        switch (type)
        {
            case "int":
                Console.WriteLine(GreaterInt());
                break;
            case "char":
                Console.WriteLine(GreaterChar());
                break;
            case "string":
                Console.WriteLine(GreaterString());
                break;
        }
    }
} */

/* #10

using System;

class Program
{
    static void GetMultipleOfEvenAndOdds(string input)
    {
        // If the input number is negative, remove the minus sign to process digits correctly
        if (input[0] == '-')
        {
            input = input.Substring(1); // Remove the negative sign
        }

        int evenSum = GetSumOfEvenDigits(input);
        int oddSum = GetSumOfOddDigits(input);
        int product = evenSum * oddSum;
        Console.WriteLine(product);
    }

    static int GetSumOfEvenDigits(string input)
    {
        int sum = 0;

        // Loop through each character in the input string
        foreach (char ch in input)
        {
            // Convert the character to an integer digit
            int digit = int.Parse(ch.ToString());

            // Check if the digit is even
            if (digit % 2 == 0)
            {
                sum += digit; // Add even digits to the sum
            }
        }

        return sum;
    }

    static int GetSumOfOddDigits(string input)
    {
        int sum = 0;

        // Loop through each character in the input string
        foreach (char ch in input)
        {
            // Convert the character to an integer digit
            int digit = int.Parse(ch.ToString());

            // Check if the digit is odd
            if (digit % 2 != 0)
            {
                sum += digit; // Add odd digits to the sum
            }
        }

        return sum;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        GetMultipleOfEvenAndOdds(input);
    }
} */
