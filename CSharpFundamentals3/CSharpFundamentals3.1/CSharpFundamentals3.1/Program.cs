/* #1

int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int sum = 0;

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    sum += arr[i];
}

// Print array elements in one line
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");  // Print elements with space
}

Console.WriteLine(); // Print a newline after the array

Console.WriteLine(sum); */

/* #2
// Read the first line of input, split it into an array of strings based on whitespace
string[] first = Console.ReadLine().Split();

// Read the second line of input, split it into an array of strings based on whitespace
string[] second = Console.ReadLine().Split();

// Initialize an empty string to accumulate the result (common elements)
string result = "";

// Iterate over each element in the second array
foreach (var kvp in second)
{
    // Check if the current element from 'second' exists in the 'first' array
    if (first.Contains(kvp))
    {
        // If the element is found in both arrays, add it to the result string with a leading space
        result += " " + kvp;
    }
}

// Output the result string with any leading/trailing whitespace removed
Console.Write($"{result.Trim()}"); */

/* #3

// Read the number of pairs to process
int number = int.Parse(Console.ReadLine());

// Initialize two arrays to store values for first and second sets
int[] firstArray = new int[number];
int[] secondArray = new int[number];

// Loop through each pair based on the given number
for (int index = 0; index < number; index++)
{
    // Read a line of input, split it by spaces, convert to integers and store in 'input' array
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

    // Use ternary operator to decide the order of values for each array based on the index
    // If index is even, input[0] goes to firstArray, input[1] to secondArray
    // If index is odd, input[1] goes to firstArray, input[0] to secondArray
    (firstArray[index], secondArray[index]) = index % 2 == 0 ? (input[0], input[1]) : (input[1], input[0]);
}

// Print out the first and second arrays with space-separated values
Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray)); */

/* #4 

string word = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

string[] nums = word.Split(' ');

for (int j = 0; j < n; j++)
{
    var temp = nums[0];
    for (var i = 0; i < nums.Length - 1; i++)
    {
        nums[i] = nums[i + 1];
    }
    nums[nums.Length - 1] = temp;
}
Console.WriteLine("{0}", string.Join(" ", nums)); */

/* #5 

// Read a line of input, split it by spaces, parse each part as a long number, and store them in an array
long[] inputArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

// Loop through each element in the array
for (long i = 0; i < inputArr.Length; i++)
{
    // Assume current number is a "top integer"
    bool isItBigger = true;

    // Check all elements to the right of the current element
    for (long j = i + 1; j < inputArr.Length; j++)
    {
        // If any number to the right is greater than or equal to current number
        if (inputArr[i] <= inputArr[j])
        {
            // Then it's not a "top integer"
            isItBigger = false;
        }
    }

    // If no number to the right was greater or equal, print this number
    if (isItBigger)
    {
        Console.Write(inputArr[i] + " ");
    }
} */


/* #6

using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;

            for (int i = 0; i < values.Length; i++)
            {
                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += values[k];
                }

                int rightSum = 0;
                for (int j = values.Length - 1; j > i; j--)
                {
                    rightSum += values[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return; // Exit the program immediately after finding the first match
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
} */

/* #7 

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int counter = 0;
int winningCounter = 0;
int index = 0;
string number = string.Empty;

for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        counter++;
        if (counter > winningCounter)
        {
            winningCounter = counter;
            index = i;
            number = numbers[i].ToString();
        }
    }
    else
    {
        counter = 0;
    }
}
for (int i = 0; i <= winningCounter; i++)
{
    Console.Write(number + " ");
} */

/* #8

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine()); 

// Loop over the array, but stop at the second-to-last element to avoid out of bounds error
for (int i = 0; i < numbers.Length - 1; i++)
{
    for(int j=i+1; j < numbers.Length; j++) { 
        int sum = numbers[i] + numbers[j]; 
    
        if (sum == n)
        {
                Console.Write(numbers[i] + " " + numbers[j]);
                Console.WriteLine();
        }
    }
 } */
