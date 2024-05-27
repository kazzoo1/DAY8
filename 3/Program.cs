using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "Мама мыла раму. В парке гуляли люди. Солнце светит ярко и красиво. В лесу встретили медведя, который был очень большой.";
        int n = 4; // Задаем минимальное количество слов в предложении
        string sentencePattern = @"[А-Я].*?[.!?](?=\s|$)";
        string wordPattern = @"\b(\w+)\b";

        MatchCollection sentences = Regex.Matches(text, sentencePattern);

        Console.WriteLine($"Предложения содержащие не меньше {n} слов:");
        foreach (Match sentence in sentences)
        {
            var wordCount = Regex.Matches(sentence.Value, wordPattern).Count;
            if (wordCount >= n)
            {
                Console.WriteLine(sentence.Value);
            }
        }
    }
}
