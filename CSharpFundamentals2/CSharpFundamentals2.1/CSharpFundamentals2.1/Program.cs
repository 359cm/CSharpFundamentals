/* #2

int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n != 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine(sum); */

/* #3

int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int course = n / p;
if (n%p>0) { course++; }

Console.WriteLine(course); */

/* #6

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            char firstChar = (char)('a' + i);
            char secondChar = (char)('a' + j);
            char thirdChar = (char)('a' + k);
            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
} */

/* #7

int n = int.Parse(Console.ReadLine());
int tank = 0;

for (int i = 0; i < n; i++)
{
    int add = int.Parse(Console.ReadLine());
    tank += add;

    if (tank > 255) { Console.WriteLine("Insufficient capacity!"); tank -= add; }
}

Console.WriteLine(tank); */