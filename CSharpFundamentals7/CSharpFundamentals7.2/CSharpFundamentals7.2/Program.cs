/* #1

double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
var counts = new SortedDictionary<double, int>();

foreach (var num in nums)
{
    if (counts.ContainsKey(num)) counts[num]++; // If the number is already in the dictionary, increment its count.
    else counts[num] = 1; // If it's not in the dictionary yet, add it with a count of 1.
}

foreach (var num in counts) // The numbers will be printed in ascending order because it's a SortedDictionary.
{
    Console.WriteLine($"{num.Key} -> {num.Value}");
} */

/* #2 string[] words = Console.ReadLine().Split();

Dictionary<string, int> counts = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordInLowerCase = word.ToLower(); // Convert the word to lowercase to make the counting case-insensitive
    if (counts.ContainsKey(wordInLowerCase)) {  counts[wordInLowerCase]++; } // If the word is already in the dictionary, increment its count
    else { counts.Add(wordInLowerCase, 1); } // Otherwise, add the word to the dictionary with an initial count of 1
}

foreach (var count in counts)
{
    if (count.Value%2 != 0)
    {
        Console.Write(count.Key + " ");
    }
} */

/* #3

int n = int.Parse(Console.ReadLine());
var words = new Dictionary<string, List<string>>(); // Create a dictionary where each word (string) maps to a list of its synonyms (List<string>).

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();
    if (words.ContainsKey(word) == false) { words.Add(word, new List<string>()); } // Check if the word is already in the dictionary.
    words[word].Add(synonym); // Add the synonym to the list of synonyms for that word.
}

// Loop through each word and its list of synonyms in the dictionary
foreach (var entry in words)
{
    // Join all synonyms into a single comma-separated string
    string synonyms = string.Join(", ", entry.Value);

    // Print the word and its synonyms in the specified format
    Console.WriteLine($"{entry.Key} - {synonyms}");
} */

string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();
foreach (string word in words) Console.WriteLine(word);