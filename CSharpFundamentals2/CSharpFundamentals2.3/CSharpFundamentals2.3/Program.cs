/* #2

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine(); 
    char delimiter = ' ';
    string[] splitNumbers = input.Split(delimiter);

    long leftNum = long.Parse(splitNumbers[0]);
    long rightNum = long.Parse(splitNumbers[1]);

    long biggerNumber = rightNum;
    if (leftNum > rightNum)
    {
        biggerNumber = leftNum;
    }

    long sumOfDigits = 0;
    while (biggerNumber != 0)
    {
        sumOfDigits += biggerNumber % 10;
        biggerNumber /= 10;
    }
    Console.WriteLine(Math.Abs(sumOfDigits));
} */

/* #5

int key = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string word = "";

for (int i = 0; i < n; i++)
{
    char letter = char.Parse(Console.ReadLine());
    int index = letter + key;
    word += ((char) index).ToString();
}

Console.WriteLine(word); */

/* #6

long n = long.Parse(Console.ReadLine());
long openCount = 0;
long closeCount = 0;

for (int i = 1; i <= n; i++)
{
    string input = Console.ReadLine();
    if (input == "(")
    {
        openCount++;

    }
    else if (input == ")")
    {
        closeCount++;
        if (openCount - closeCount != 0)
        {
            Console.WriteLine("UNBALANCED");
            return;
        }
    }
}
if (openCount == closeCount)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
} */