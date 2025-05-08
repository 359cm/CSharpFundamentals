/* #1 

using System;  // Import the System namespace for common functionality (e.g., Console)

class Program  
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string input = Console.ReadLine();

        // Switch statement to handle different types based on the input
        switch (type)
        {
            case "int":  
                DataTypes(int.Parse(input));
                break;

            case "real":  
                DataTypes(double.Parse(input));
                break;

            case "string":  
                DataTypes(input);
                break;
        }
    }

    static void DataTypes(int value)
    {
        Console.WriteLine(value * 2);
    }

     static void DataTypes(double value)
    {
        Console.WriteLine($"{value * 1.5:F2}");
    }

    static void DataTypes(string value)
    {
        Console.WriteLine($"${value}$");
    }
} */

/* #2
using System;
class Program
{
    static void Main(string[] num)
    {
        // Reading the arrays
        int[] x = new int[2];
        int[] y = new int[2];

        for (int i = 0; i < 2; i++)
        {
            x[i] = int.Parse(Console.ReadLine());
            y[i] = int.Parse(Console.ReadLine());
        }

        int sum1 = int.MaxValue, sum2 = 0, x1 = 0, x2 = 0;

        // Finding the pair that gives the smallest sum
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                sum2 = x[i] + y[j];
                if (sum2 < sum1)
                {
                    sum1 = sum2;
                    x1 = x[i];
                    x2 = y[j];  // Store the pair that gives the smallest sum
                }
            }
        }

        // Output the result
        Console.WriteLine($"({x1}, {x2})");
    }
} */

/* #3
using System;
using System.Linq;

namespace example
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void ClosestToZero(double a, double b, double c, double d)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(a), 2) + Math.Pow(Math.Abs(b), 2));
            double second = Math.Sqrt(Math.Pow(Math.Abs(c), 2) + Math.Pow(Math.Abs(d), 2));
            if (first > second)
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
        }

        static void LongestLine(double a, double b, double c, double d, double e, double f, double g, double h)
        {
            double firstLine = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double secondLine = Math.Sqrt(Math.Pow(Math.Abs(e - g), 2) + Math.Pow(Math.Abs(f - h), 2));
            if (firstLine >= secondLine)
            {
                ClosestToZero(a, b, c, d);
            }
            else
            {
                ClosestToZero(e, f, g, h);
            }
        }
    }
} */

/* #4
using System;
using System.Numerics;

namespace _04.TribonacciSequence_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[] result = TribonacciNumbers(n);

            Console.WriteLine(String.Join(' ', result));
        }

        private static BigInteger[] TribonacciNumbers(int n)
        {
            BigInteger[] result = new BigInteger[n];

            switch (n)
            {
                case 1:
                    result[0] = 1;
                    break;
                case 2:
                    result[0] = 1;
                    result[1] = 1;
                    break;
                case 3:
                    result[0] = 1;
                    result[1] = 1;
                    result[2] = 2;
                    break;
                default:
                    result[0] = 1;
                    result[1] = 1;
                    result[2] = 2;
                    for (int i = 3; i < n; i++)
                    {
                        BigInteger currNum = result[i - 3] + result[i - 2] + result[i - 1];
                        result[i] = currNum;
                    }
                    break;
            }

            return result;
        }
    }
} */