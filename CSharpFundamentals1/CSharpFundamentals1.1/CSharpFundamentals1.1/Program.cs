/* #1 

int age = int.Parse(Console.ReadLine());

if (age <= 2) { Console.WriteLine("baby"); }
if (age > 2 && age <= 13) { Console.WriteLine("child"); }
if (age > 13 && age <= 19) { Console.WriteLine("teenager"); }
if (age > 19 && age <= 65) { Console.WriteLine("adult"); }
if (age >= 66) { Console.WriteLine("elder"); } */

/* #2

int num = int.Parse(Console.ReadLine());

if (num % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
}
else if (num % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
}
else if (num % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
}
else if (num % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
}
else if (num % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
}
else
{
    Console.WriteLine("Not divisible");
} */


/* #3

int count = int.Parse(Console.ReadLine());
string group = Console.ReadLine();
string day = Console.ReadLine();
double price = 0;
double totalPrice = 0;

if (group == "Students")
{
    if (day == "Friday") price = 8.45;
    else if (day == "Saturday") price = 9.80;
    else if (day == "Sunday") price = 10.46;
}

else if (group == "Business")
{
    if (day == "Friday") price = 10.90;
    else if (day == "Saturday") price = 15.60;
    else if (day == "Sunday") price = 16.00;
}

else if (group == "Regular")
{
    if (day == "Friday") price = 15.00;
    else if (day == "Saturday") price = 20.00;
    else if (day == "Sunday") price = 22.50;
}

if (group == "Business" && count >= 100)
{
    count -= 10; 
}

totalPrice = price * count;

if (group == "Students" && count >= 30)
{
    totalPrice *= 0.85; 
}

if (group == "Regular" && count >= 10 && count <= 20)
{
    totalPrice *= 0.95; 
}

Console.WriteLine($"Total price: {totalPrice:F2}"); */


/* #4

int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = start; i <= end; i++)
{
    Console.Write($"{i} "); // Changed from WriteLine to Write and added a space for separation
    sum += i;
}

Console.WriteLine(); // Move to the next line after the loop
Console.WriteLine($"Sum: {sum}"); */


/* #5

string username = Console.ReadLine();
string realPassword = new string(username.Reverse().ToArray());
string password = "";
int failedAttempts = 0;

do
{
    password = Console.ReadLine();
    if (password == realPassword)
    {
        Console.WriteLine($"User {username} logged in.");
        return;
    }
    else
    {
        failedAttempts++;
        Console.WriteLine($"Incorrect password. Try again.");
    }
} while (failedAttempts < 3);

if(failedAttempts == 3)
{
    Console.WriteLine($"User {username} blocked!");
} */


/* #6

int num = int.Parse(Console.ReadLine());
        int originalNum = num;  // Store the original number
        int sum = 0;

        // Function to calculate the factorial of a number
        int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // Loop through each digit of the number
        while (num > 0)
        {
            int digit = num % 10;  // Get the last digit
            sum += Factorial(digit);  // Add the factorial of the digit to sum
            num = num / 10;  // Remove the last digit
        }

        // Compare the sum of the factorials to the original number
        if (sum == originalNum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        } */


/* #7

double total = 0;
bool Start = false, End = false;

while (!Start)
{
    var input = Console.ReadLine();

    if (input == "Start")
    {
        Start = true;
    }
    else
    {
        // Try to parse the input into a double
        if (double.TryParse(input, out double value))
        {
            // Check if the input value is valid
            if (value == 0.1 || value == 0.2 || value == 0.5 || value == 1 || value == 2)
            {
                total += value;
            }
            else
            {
                Console.WriteLine($"Cannot accept {value}");
            }
        }
    }
}

while (!End)
{
    var input = Console.ReadLine();

    if (input == "End")
    {
        End = true;
    }
    else
    {
        // Define prices for each product with two decimal places
        var prices = new Dictionary<string, double>
        {
            { "Nuts", 2.00 },
            { "Water", 0.70 },
            { "Crisps", 1.50 },
            { "Soda", 0.80 },
            { "Coke", 1.00 }
        };

        if (prices.ContainsKey(input))
        {
            double price = prices[input];

            // Check if there is enough money
            if (total >= price)
            {
                total -= price;
                Console.WriteLine($"Purchased {input.ToLower()}");
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
            }
        }
        else
        {
            Console.WriteLine($"Invalid product");
        }
    }
}

// Display the change with two decimal places
Console.WriteLine($"Change: {total:F2}"); */


/* #7

int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write($"{i} ");
    Console.WriteLine();
} */
