/* #1

int n = int.Parse(Console.ReadLine());
int sumVowels = 0;
int sumConsonant = 0;
int sum = 0;
string vowels = "EeUuIiOoAa"; // добавено

int[] arrayOfSums = new int[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    for (int j = 0; j < name.Length; j++)
    {
        char currentLetter = name[j]; // това трябва да е чар

        if (vowels.Contains(currentLetter)) // променено
        {
            sumVowels += currentLetter * name.Length;
        }
        else
        {
            sumConsonant += currentLetter / name.Length;
        }
    }
    sum = sumVowels + sumConsonant;
    arrayOfSums[i] = sum;

    sumVowels = 0;
    sumConsonant = 0;
    sum = 0;

}

Array.Sort(arrayOfSums);
for (int i = 0; i < arrayOfSums.Length; i++)
{
    Console.WriteLine(arrayOfSums[i]);
} */

/* #2 var lines = int.Parse(Console.ReadLine());
var pascalTriangle = new long[lines][]; // Declare a jagged array (array of arrays), where each inner array represents a row of Pascal's Triangle

for (var row = 0; row < lines; row++)
{
    pascalTriangle[row] = new long[row + 1];
    pascalTriangle[row][0] = 1;  // first element is 1
    pascalTriangle[row][^1] = 1; // '^1' means "the last index"

    for (var col = 1; col < row; col++)
    {
        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
    }
}

for (var row = 0; row < lines; row++)
{
    Console.WriteLine(string.Join(" ", pascalTriangle[row]));
} */

/* #3
int num = int.Parse(Console.ReadLine());

// Initialize an array with the first two Fibonacci numbers
int[] array = new int[] { 1, 1 };

// Variable to store the current Fibonacci sum
int sum = 0;

// Handle special cases: when the user inputs 1 or 2
switch (num)
{
    case 1:
        // For the 1st Fibonacci number, output 1 and exit
        Console.WriteLine("1");
        return;
    case 2:
        // For the 2nd Fibonacci number, also output 1 and exit
        Console.WriteLine("1");
        return;
}

// Loop starts from index 2 (since 0 and 1 are already handled)
// We compute Fibonacci numbers up to the nth number
for (int i = 2; i < num; i++)
{
    // Compute next Fibonacci number by summing the last two
    sum = array[0] + array[1];

    // Shift the array to keep the last two Fibonacci numbers
    // Example: if array = {1, 2}, then newArray = {2, 3}
    int[] newArray = new int[] { array[1], sum };

    // Update the array to point to the new last two numbers
    array = newArray;
}

// After the loop ends, 'sum' holds the nth Fibonacci number
Console.WriteLine(sum); */

