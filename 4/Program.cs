using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Анна идет в парк, там она ест мороженое, видит летучую мышь, пеликана и ездит на катамаране.";
        string pattern = @"\b(\w)\w*\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
