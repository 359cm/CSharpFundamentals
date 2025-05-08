/* #1

using System;

class Program
{
    static void Main()
    {
        // Step 1: Read input and split into words
        string[] words = Console.ReadLine().Split(' ');

        // Step 2: Create a random number generator
        Random rnd = new Random();

        // Step 3: Shuffle the array using random swaps
        for (int pos1 = 0; pos1 < words.Length; pos1++)
        {
            int pos2 = rnd.Next(words.Length); // random index
            // Swap words[pos1] and words[pos2]
            string temp = words[pos1];
            words[pos1] = words[pos2];
            words[pos2] = temp;
        }

        // Step 4: Print each word on a new line
        Console.WriteLine(string.Join(Environment.NewLine, words));
    }
} */


/* #2

using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger f = 1;
for(int i = 2;i<=n;i++) {f*=i;}
Console.WriteLine(f); */

/*#3

using System;
using System.Collections.Generic;

class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

class Program
{
    static void Main()
    {
        int numSongs = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < numSongs; i++)
        {
            string[] data = Console.ReadLine().Split("_");

            string type = data[0];
            string name = data[1];
            string time = data[2];

            Song song = new Song
            {
                TypeList = type,
                Name = name,
                Time = time
            };

            songs.Add(song);
        }

        string typeList = Console.ReadLine();

        if (typeList == "all") // If "all", print the names of all songs
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else // Otherwise, print names of songs that match the given type
        {
            foreach (Song song in songs)
            {
                if (song.TypeList == typeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
} */

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        string line = Console.ReadLine();
        while (line != "end")
        {
            string[] tokens = line.Split();

            string firstName = tokens[0];
            string lastName = tokens[1];
            int age = int.Parse(tokens[2]);
            string city = tokens[3];

            if (IsStudentExisting(students, firstName, lastName))
            {
                // If student exists, find the student and update their data (age and city).
                Student existingStudent = GetStudent(students, firstName, lastName);
                existingStudent.Age = age;
                existingStudent.City = city;
            }
            else
            { // If the student doesn't exist, create a new Student object.
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);
            }

            line = Console.ReadLine();
        }

        string filterCity = Console.ReadLine();

        List<Student> filteredStudents = students
            .Where(s => s.City == filterCity)
            .ToList();

        foreach (Student student in filteredStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
        }
    }

    static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
    { // Use LINQ to search for a student with the same first and last name.
        return students.Any(s => s.FirstName == firstName && s.LastName == lastName);
    }

    static Student GetStudent(List<Student> students, string firstName, string lastName)
    { // Use LINQ to find the student in the list and return them.
        return students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
    }
}
