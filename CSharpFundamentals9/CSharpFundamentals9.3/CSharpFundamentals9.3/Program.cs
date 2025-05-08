/* #1

using System.Text.RegularExpressions; // Import the namespace for working with regular expressions

class Program
{
    static void Main(string[] args)
    {
        // Define a regular expression pattern to match a valid full name
        // \b           → Word boundary (ensures we don't match inside another word)
        // [A-Z]        → The first letter of the word must be an uppercase letter
        // [a-z]+       → Followed by one or more lowercase letters (ensures the word is at least 2 characters long)
        //              → A single space separates the two words
        // [A-Z][a-z]+  → The second word follows the same rule: uppercase first, then lowercase letters
        // \b           → End of the word boundary
        string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        string names = Console.ReadLine();

        // Use Regex.Matches to find all matches of the full name pattern in the input string
        // This returns a collection of Match objects, each representing a valid full name found
        MatchCollection matchedNames = Regex.Matches(names, regex);

        foreach (Match name in matchedNames)
        {
            Console.Write(name.Value + " ");
        }

        Console.WriteLine();
    }
} */

/* #2

using System.Text.RegularExpressions; // Used for working with regular expressions

class Program
    {
        static void Main(string[] args)
        {
            // Define the regular expression pattern
            // The regex pattern to match valid Sofia phone numbers in the format:
            // +359 2 111 111 or +359-2-111-111 (with space or hyphen delimiters)
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            string phones = Console.ReadLine();

            // Regex.Matches returns a collection of all phone numbers that match the regex pattern
            MatchCollection phoneMatches = Regex.Matches(phones, pattern);

            // Cast the collection of matches into an array of strings (using LINQ)
            // Cast<Match>() converts the collection to an enumerable collection of Match objects
            // Select(x => x.Value.Trim()) extracts the matched phone numbers and trims any leading or trailing whitespace
            string[] matchPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            // string.Join(", ", matchPhones) joins all elements in the array using ", " as the separator
            Console.WriteLine(string.Join(", ", matchPhones));
        }
 } */


/* #3

using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        // The pattern ensures:
        // - Day is two digits.
        // - Month is a three-letter abbreviation with the first letter uppercase.
        // - Separator is consistent across the date (either '.', '-', or '/').
        // - Year is exactly four digits.
        string pattern = @"\b(?<day>\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match date in matches)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
} */
