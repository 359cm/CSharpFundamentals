/* #1

string line = Console.ReadLine();

while (line != "end")
    {
        string reversed = "";

        for (int i = line.Length - 1; i >= 0; i--)
        {
            reversed += line[i];
        }

        Console.WriteLine($"{line} = {reversed}");
        line = Console.ReadLine(); // Read the next line of input to continue or break the loop
} */

/* #2

using System.Text;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();
        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            int repeatTimes = word.Length;
            for (int i = 0; i < repeatTimes; i++)
            {
                result.Append(word);
            }
        }

        Console.WriteLine(result.ToString());
    }
} */

/* #3

string key = Console.ReadLine();
string text = Console.ReadLine();

int index = text.IndexOf(key);
// Find the first occurrence of 'key' in 'text'
// If the key is not found, IndexOf returns -1

while (index!= -1) // Loop as long as 'key' is found in 'text'
{
    text = text.Remove(index, key.Length);// Remove the found occurrence of 'key' from 'text'
                                          // 'index' is the start position, 'key.Length' is the number of characters to remove

    index = text.IndexOf(key); // Search again for the next occurrence of 'key' in the updated 'text'
}

Console.WriteLine(text); */

/* #4

using System;

class Program{
    static void Main()
    {
        // Read the banned words from the first line, separated by ", "
        string[] banWords = Console.ReadLine()
            .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

        // Read the text from the second line
        string text = Console.ReadLine();

        // Replace each banned word with asterisks of the same length
        foreach (var banWord in banWords)
        {
            if (text.Contains(banWord))
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }
        }

        Console.WriteLine(text);
    }
} */

/* #5

using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        StringBuilder digits = new StringBuilder();
        StringBuilder letters = new StringBuilder();
        StringBuilder others = new StringBuilder();

        foreach (char ch in input)
        {
            if (char.IsDigit(ch))
            {
                digits.Append(ch);
            }
            else if (char.IsLetter(ch))
            {
                letters.Append(ch);
            }
            else
            {
                others.Append(ch);
            }
        }

        Console.WriteLine(digits.ToString());
        Console.WriteLine(letters.ToString());
        Console.WriteLine(others.ToString());
    }
} */
