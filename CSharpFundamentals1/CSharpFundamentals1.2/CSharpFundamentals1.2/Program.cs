/* #1

string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double grade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}"); */

/* #2 + #3

double grade = double.Parse(Console.ReadLine());

if(grade>=3) { Console.WriteLine($"Passed!"); }
else { Console.WriteLine($"Failed!"); }  */

/* #4

int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 30;
if (minutes >= 60)
{
    int extra = minutes - 60;
    hours++;
    minutes = extra;
}
if (hours > 23)
{
    hours -= 24;
}

Console.WriteLine($"{hours}:{minutes:D2}"); */

/* #5

int num = int.Parse(Console.ReadLine());

switch (num)
    {
        case 1:
            Console.WriteLine("January");
            break;
        case 2:
            Console.WriteLine("February");
            break;
        case 3:
            Console.WriteLine("March");
            break;
        case 4:
            Console.WriteLine("April");
            break;
        case 5:
            Console.WriteLine("May");
            break;
        case 6:
            Console.WriteLine("June");
            break;
        case 7:
            Console.WriteLine("July");
            break;
        case 8:
            Console.WriteLine("August");
            break;
        case 9:
            Console.WriteLine("September");
            break;
        case 10:
            Console.WriteLine("October");
            break;
        case 11:
            Console.WriteLine("November");
            break;
        case 12:
            Console.WriteLine("December");
            break;
        default:
            Console.WriteLine("Error!");
            break;
    } */
