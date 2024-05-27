using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Это очень вкусное блюдо, особенно понравится тем, кто любит сладкое и ароматное.";
        string pattern = @"\w*[аеёиоуыэюя]{2,}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
