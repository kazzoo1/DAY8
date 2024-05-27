using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "Мама мыла раму. В парке парке гуляли люди. Солнце светит ярко и красиво. В лесу встретили встретили медведя.";
        string sentencePattern = @"[А-Я].*?[.!?](?=\s|$)";
        string wordPattern = @"\b(\w+)\b";

        MatchCollection sentences = Regex.Matches(text, sentencePattern);

        Console.WriteLine("Исходные предложения:");
        foreach (Match sentence in sentences)
        {
            Console.WriteLine(sentence.Value);
        }

        Console.WriteLine("\nПредложения с повторяющимися словами:");
        foreach (Match sentence in sentences)
        {
            var words = new Dictionary<string, int>();
            bool hasRepeats = false;
            foreach (Match wordMatch in Regex.Matches(sentence.Value, wordPattern))
            {
                string word = wordMatch.Groups[1].Value.ToLower();
                if (words.ContainsKey(word))
                {
                    words[word]++;
                    hasRepeats = true;
                }
                else
                {
                    words[word] = 1;
                }
            }

            if (hasRepeats)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}
